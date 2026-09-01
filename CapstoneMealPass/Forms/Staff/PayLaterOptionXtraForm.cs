using CapstoneMealPass.Helpers;
using MealPass.Business.Services;
using MealPass.Core.Entity;
using MealPass.Core.GlobalSql;
using MealPass.Core.Interface;
using MealPass.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;

namespace CapstoneMealPass.Forms.Staff
{
    public partial class PayLaterOptionXtraForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly TransactionData _transaction;
        private RFIDReaderService _rfidService;
        private readonly PaymentOptionXtraForm _paymentForm;
        private readonly POSUserControl _posControl;
        private readonly ISBalanceRepository _sBalanceRepo;

        private string _scannedRFID;
        private string _staffId;
        private decimal _outstandingCredit;

        public PayLaterOptionXtraForm(TransactionData transaction, PaymentOptionXtraForm paymentForm, POSUserControl posControl)
        {
            InitializeComponent();
            _transaction = transaction;
            _paymentForm = paymentForm;
            _posControl = posControl;

            string connectionString = SQLQuery.connectionString;

            var staffRepo = new StaffRepository(connectionString);
            var sBalanceRepo = new SBalanceRepository(connectionString);

            CheckForIllegalCrossThreadCalls = false;
        }
        private void PayLaterOptionXtraForm_Load(object sender, EventArgs e)
        {
            SetupRFIDReader();
            InitializeLabels();
            staffidTE.ReadOnly = true;
        }

        private void InitializeLabels()
        {
            totalamountLBL.Text = _transaction.GrandTotal.ToString("N2");
            staffidTE.Text = string.Empty;
            outstandingcreditLBL.Text = "0.00";
            newoutstandingcreditLBL.Text = "0.00";
        }

        private void SetupRFIDReader()
        {
            _rfidService = new RFIDReaderService();

            // Subscribe to RFID events
            _rfidService.OnCardScanned += RFID_CardScanned;
            _rfidService.OnCardRemoved += RFID_CardRemoved;
            _rfidService.OnStatusChanged += RFID_StatusChanged;

            // Initialize
            _rfidService.Initialize();
        }

        private void RFID_StatusChanged(string message)
        {
            // Update status label safely
            if (InvokeRequired)
                Invoke(new Action(() => statusLBL.Text = message));
            else
                statusLBL.Text = message;
        }

        private async void RFID_CardScanned(string rfid)
        {
            _scannedRFID = rfid;

            if (InvokeRequired)
                Invoke(new Action(async () => await ProcessRFID(rfid)));
            else
                await ProcessRFID(rfid);
        }

        private void RFID_CardRemoved()
        {
            if (InvokeRequired)
                Invoke(new Action(() =>
                {
                    statusLBL.Text = "Card removed";
                }));
            else
                statusLBL.Text = "Card removed";
        }

        private async Task ProcessRFID(string rfid)
        {
            try
            {
                string connectionString = SQLQuery.connectionString;
                // Look up staff
                var staffRepo = new StaffRepository(connectionString);
                var sBalanceRepo = new SBalanceRepository(connectionString);

                var staff = await staffRepo.GetStaffByRFIDAsync(rfid);

                if (staff == null)
                {
                    MessageBox.Show("RFID is not associated with any staff.", "Not Found");
                    return;
                }

                _staffId = staff.StaffID;
                staffidTE.Text = _staffId;

                // Load or create SBalance record
                var sBalance = await sBalanceRepo.GetSBalanceByStaffIDAsync(_staffId);

                if (sBalance == null)
                {
                    // Create new outstanding-credit record
                    await sBalanceRepo.InsertSBalanceAsync(_staffId, 0);
                    _outstandingCredit = 0;
                }
                else
                {
                    _outstandingCredit = sBalance.StaffCredit;
                }

                outstandingcreditLBL.Text = _outstandingCredit.ToString("N2");

                // Compute new outstanding credit after this purchase
                decimal total = _transaction.GrandTotal;
                decimal newOutstanding = _outstandingCredit + total;

                newoutstandingcreditLBL.Text = newOutstanding.ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error processing RFID: " + ex.Message);
            }
        }

        //public async Task RefreshStaffOutstandingAsync(string staffId)
        //{
        //    string connectionString = SQLQuery.connectionString;
        //    var sBalanceRepo = new SBalanceRepository(connectionString);
        //    var sBalance = await sBalanceRepo.GetSBalanceByStaffIDAsync(staffId);

        //    if (sBalance != null)
        //    {
        //        _outstandingCredit = sBalance.StaffCredit;
        //        outstandingcreditLBL.Text = _outstandingCredit.ToString("N2");

        //        // Recalculate new outstanding credit
        //        decimal newOutstanding = _outstandingCredit + _transaction.GrandTotal;
        //        newoutstandingcreditLBL.Text = newOutstanding.ToString("N2");
        //    }
        //}

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // ESC → Close form
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true; // mark as handled
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private async void confirmBTN_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate scan
                if (string.IsNullOrEmpty(_staffId))
                {
                    MessageBox.Show("Please scan a valid staff RFID before confirming the purchase.",
                        "Missing RFID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Ensure outstanding credit value is valid
                if (_outstandingCredit < 0)
                {
                    MessageBox.Show("Invalid outstanding credit value. Please rescan the card.",
                        "Balance Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                decimal totalAmount = _transaction.GrandTotal;

                // Check if staff account is locked
                var sBalanceRepo = new SBalanceRepository(SQLQuery.connectionString);
                bool isLocked = await sBalanceRepo.IsAccountLockedAsync(_staffId);

                if (isLocked)
                {
                    MessageBox.Show(
                        "This staff's account is currently LOCKED and cannot be used for credit purchases.\n" +
                        "Please contact an administrator.",
                        "Account Locked",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Stop);

                    return; // Stop transaction
                }

                // Initialize repositories
                var productRepo = new ProductRepository(); // implements IProductRepository
                var transactionRepo = new TransactionRepository(SQLQuery.connectionString);
                var transactionDetailRepo = new TransactionDetailRepository(SQLQuery.connectionString);

                // Generate ReferenceID (prefixed "SR" for Staff / credit transactions)
                string refId = "S" + DateTime.Now.ToString("yyMMddHHmmss") + _staffId.Substring(_staffId.Length - 4);

                // Prepare TransactionDetails
                bool hasOOS = false;
                var transactionDetails = new List<TransactionDetail>();

                foreach (DataRow row in _transaction.CartItems.Rows)
                {
                    int productId = Convert.ToInt32(row["ID"]);
                    int cartQuantity = Convert.ToInt32(row["Quantity"]);

                    // Get product details including CategoryName
                    DataRow productRow = await productRepo.GetByIdWithDetailsAsync(productId);
                    int stockQuantity = Convert.ToInt32(productRow["Quantity"]);
                    string categoryName = productRow["CategoryName"].ToString();

                    if (categoryName != "Meals")
                    {
                        // Non-meals: proceed only if stock is enough
                        if (cartQuantity > stockQuantity)
                        {
                            MessageBox.Show(
                                $"Insufficient stock for {productRow["ProductName"]}. Transaction cannot proceed.",
                                "Stock Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                            return;
                        }

                        transactionDetails.Add(new TransactionDetail
                        {
                            ReferenceID = refId,
                            ProductID = productId,
                            QuantitySold = cartQuantity,
                            UnitPrice = Convert.ToDecimal(row["Price"]),
                            Subtotal = Convert.ToDecimal(row["Total"]),
                            Remarks = "Completed"
                        });

                        await productRepo.DeductStockAsync(productId, cartQuantity);
                    }
                    else
                    {
                        // Meals: split into Completed and Out of stock purchase
                        if (cartQuantity <= stockQuantity)
                        {
                            transactionDetails.Add(new TransactionDetail
                            {
                                ReferenceID = refId,
                                ProductID = productId,
                                QuantitySold = cartQuantity,
                                UnitPrice = Convert.ToDecimal(row["Price"]),
                                Subtotal = Convert.ToDecimal(row["Total"]),
                                Remarks = "Completed"
                            });

                            await productRepo.DeductStockAsync(productId, cartQuantity);
                        }
                        else
                        {
                            // Split quantities
                            if (stockQuantity > 0)
                            {
                                transactionDetails.Add(new TransactionDetail
                                {
                                    ReferenceID = refId,
                                    ProductID = productId,
                                    QuantitySold = stockQuantity,
                                    UnitPrice = Convert.ToDecimal(row["Price"]),
                                    Subtotal = Convert.ToDecimal(row["Price"]) * stockQuantity,
                                    Remarks = "Completed"
                                });

                                await productRepo.DeductStockAsync(productId, stockQuantity);
                            }

                            transactionDetails.Add(new TransactionDetail
                            {
                                ReferenceID = refId,
                                ProductID = productId,
                                QuantitySold = cartQuantity - stockQuantity,
                                UnitPrice = Convert.ToDecimal(row["Price"]),
                                Subtotal = Convert.ToDecimal(row["Price"]) * (cartQuantity - stockQuantity),
                                Remarks = "Out of stock purchase"
                            });

                            hasOOS = true;
                        }
                    }
                }

                // Insert transaction details
                foreach (var detail in transactionDetails)
                    await transactionDetailRepo.InsertTransactionDetailAsync(detail);

                // Insert master transaction
                var masterTransaction = new Transaction
                {
                    ReferenceID = refId,
                    SaleDate = DateTime.Now,
                    StudentID = _staffId, // staff identifier reused in the same column, adjust if a separate StaffID column exists
                    Username = UserSession.Username,
                    TotalAmount = totalAmount,
                    PaymentMethod = 1, // 1 = Pay Later / Credit, adjust to match your PaymentMethod convention
                    Remarks = hasOOS ? "Out of stock purchase" : "Completed"
                };

                await transactionRepo.InsertTransactionAsync(masterTransaction);

                // Update staff outstanding credit (credit purchase increases what they owe)
                decimal newOutstanding = _outstandingCredit + totalAmount;
                await sBalanceRepo.UpdateStaffCreditAsync(_staffId, newOutstanding);
                _outstandingCredit = newOutstanding;

                // Update UI
                outstandingcreditLBL.Text = newOutstanding.ToString("N2");
                newoutstandingcreditLBL.Text = newOutstanding.ToString("N2");

                MessageBox.Show(hasOOS
                    ? "Credit purchase completed with OUT-OF-STOCK items!"
                    : "Credit purchase completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _posControl?.ReloadItems();
                _transaction.CartItems.Clear();
                _paymentForm?.Close();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error confirming credit purchase: " + ex.Message,
                    "Transaction Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}