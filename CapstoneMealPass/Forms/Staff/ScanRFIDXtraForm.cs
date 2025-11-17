using CapstoneMealPass.Helpers;
using DevExpress.Utils.About;
using DevExpress.XtraEditors;
using DevExpress.XtraGauges.Core.Primitive;
using MealPass.Business.Services;
using MealPass.Core.Entity;
using MealPass.Core.GlobalSql;
using MealPass.Data.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapstoneMealPass.Forms.Staff
{
    public partial class ScanRFIDXtraForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly TransactionData _transaction;
        private RFIDReaderService _rfidService;
        private readonly PaymentOptionXtraForm _paymentForm;
        private readonly POSUserControl _posControl;

        private string _scannedRFID;
        private string _studentId;
        private decimal _studentBalance;

        public ScanRFIDXtraForm(TransactionData transaction, PaymentOptionXtraForm paymentForm, POSUserControl posControl)
        {
            InitializeComponent();
            _transaction = transaction;
            _paymentForm = paymentForm;
            _posControl = posControl;

            string connectionString = SQLQuery.connectionString;

            var studentRepo = new StudentRepository(connectionString);
            var balanceRepo = new BalanceRepository(connectionString);

            CheckForIllegalCrossThreadCalls = false;
        }

        private async void confirmBTN_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate scan
                if (string.IsNullOrEmpty(_studentId))
                {
                    MessageBox.Show("Please scan a valid student RFID before confirming the purchase.",
                        "Missing RFID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Ensure balance validity
                if (_studentBalance < 0)
                {
                    MessageBox.Show("Invalid student balance. Please rescan the card.",
                        "Balance Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check sufficient balance
                decimal totalAmount = _transaction.GrandTotal;
                if (_studentBalance < totalAmount)
                {
                    var result = MessageBox.Show("Insufficient balance. Would you like to top up now?","Not Enough Balance",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        var topUpForm = new TopUpXtraForm(_studentId, _studentBalance, this);
                        topUpForm.ShowDialog();

                        // Refresh balance after top-up
                        await RefreshStudentBalanceAsync(_studentId);

                        // Recheck balance after top-up
                        if (_studentBalance < totalAmount)
                        {
                            MessageBox.Show("Balance is still insufficient after top-up.", "Transaction Halted", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    return;

                }
                
                // Compute new balance
                decimal newBalance = _studentBalance - totalAmount;

                // Initialize repositories
                string connectionString = SQLQuery.connectionString;
                var balanceRepo = new BalanceRepository(connectionString);
                var transactionRepo = new TransactionRepository(connectionString);
                var transactionDetailRepo = new TransactionDetailRepository(connectionString);
                var productRepo = new ProductRepository();

                // Generate ReferenceID
                string refId = "R" +
                    DateTime.Now.ToString("yyMMddHHmmss") +
                    _studentId.Substring(_studentId.Length - 4);

                // Insert master Transaction
                var transaction = new MealPass.Core.Entity.Transaction
                {
                    ReferenceID = refId,
                    SaleDate = DateTime.Now,
                    StudentID = _studentId,
                    Username = UserSession.Username,
                    TotalAmount = totalAmount,
                    PaymentMethod = 0,
                    Remarks = "Completed"
                };

                await transactionRepo.InsertTransactionAsync(transaction);

                // Insert Transaction Details (no TransactionDetailID needed)
                foreach (DataRow row in _transaction.CartItems.Rows)
                {
                    int productId = Convert.ToInt32(row["ID"]);
                    int quantity = Convert.ToInt32(row["Quantity"]);

                    var detail = new MealPass.Core.Entity.TransactionDetail
                    {
                        ReferenceID = refId,
                        ProductID = Convert.ToInt32(row["ID"]),
                        QuantitySold = Convert.ToInt32(row["Quantity"]),
                        UnitPrice = Convert.ToDecimal(row["Price"]),
                        Subtotal = Convert.ToDecimal(row["Total"]),
                    };

                    await transactionDetailRepo.InsertTransactionDetailAsync(detail);

                    // Deduct stock
                    await productRepo.DeductStockAsync(productId, quantity);
                }

                // Update Balance
                await balanceRepo.UpdateBalanceAsync(_studentId, newBalance);

                // Update UI
                accountbalanceLBL.Text = newBalance.ToString("N2");
                remainingLBL.Text = "0.00";
                remainingLBL.ForeColor = Color.Green;

                MessageBox.Show("Purchase completed successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                _posControl?.ReloadItems(); 

                _transaction.CartItems.Clear(); 

                _paymentForm?.Close();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error confirming purchase: " + ex.Message,
                    "Transaction Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ScanRFIDXtraForm_Load(object sender, EventArgs e)
        {
            SetupRFIDReader();
            InitializeLabels();
            studentidTE.ReadOnly = true;
        }

        private void InitializeLabels()
        {
            totalamountLBL.Text = _transaction.GrandTotal.ToString("N2");
            studentidTE.Text = string.Empty;
            accountbalanceLBL.Text = "0.00";
            remainingLBL.Text = "0.00";
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
                // Look up student
                var studentRepo = new StudentRepository(connectionString);
                var balanceRepo = new BalanceRepository(connectionString);

                var student = await studentRepo.GetStudentByRFIDAsync(rfid);

                if (student == null)
                {
                    MessageBox.Show("RFID is not associated with any student.", "Not Found");
                    return;
                }

                _studentId = student.StudentID;
                studentidTE.Text = _studentId;

                // Load or create balance
                var balance = await balanceRepo.GetBalanceByStudentIDAsync(_studentId);

                if (balance == null)
                {
                    // Create new balance record
                    await balanceRepo.InsertBalanceAsync(_studentId, 0);
                    _studentBalance = 0;
                }
                else
                {
                    _studentBalance = balance.StudentBalance;
                }

                accountbalanceLBL.Text = _studentBalance.ToString("N2");

                // Compute remaining
                decimal total = _transaction.GrandTotal;
                decimal remaining = _studentBalance - total;

                remainingLBL.Text = remaining.ToString("N2");

                if (remaining < 0)
                {
                    remainingLBL.ForeColor = Color.Red;
                }
                else
                {
                    remainingLBL.ForeColor = Color.Green;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error processing RFID: " + ex.Message);
            }
        }

        public async Task RefreshStudentBalanceAsync(string studentId)
        {
            string connectionString = SQLQuery.connectionString;
            var balanceRepo = new BalanceRepository(connectionString);
            var balance = await balanceRepo.GetBalanceByStudentIDAsync(studentId);

            if (balance != null)
            {
                _studentBalance = balance.StudentBalance;
                accountbalanceLBL.Text = _studentBalance.ToString("N2");

                // Recalculate remaining
                decimal remaining = _studentBalance - _transaction.GrandTotal;
                remainingLBL.Text = remaining.ToString("N2");
                remainingLBL.ForeColor = remaining < 0 ? Color.Red : Color.Green;
            }
        }

    }
}