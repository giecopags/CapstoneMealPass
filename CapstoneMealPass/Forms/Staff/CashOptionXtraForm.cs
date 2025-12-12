using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapstoneMealPass.Helpers;
using DevExpress.XtraEditors;
using MealPass.Core.Entity;
using MealPass.Core.GlobalSql;
using MealPass.Core.Interface;
using MealPass.Data;
using MealPass.Data.Repositories;

namespace CapstoneMealPass.Forms.Staff
{
    public partial class CashOptionXtraForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly TransactionData _transaction;
        private readonly PaymentOptionXtraForm _paymentForm;
        private readonly POSUserControl _posControl;

        public CashOptionXtraForm(TransactionData transaction, PaymentOptionXtraForm paymentForm, POSUserControl posControl)
        {
            InitializeComponent();
            _transaction = transaction;
            _paymentForm = paymentForm;
            _posControl = posControl;

            string connectionString = SQLQuery.connectionString;

            // Display the GrandTotal in the label
            totalamountLBL.Text = _transaction.GrandTotal.ToString("N2");
            changeLBL.Text = "0.00";
            changeLBL.ForeColor = Color.Black;
        }

        private async void confirmBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (!decimal.TryParse(cashpaymentTE.Text, out decimal cashPaid))
                {
                    MessageBox.Show("Please enter a valid cash amount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal totalAmount = _transaction.GrandTotal;
                if (cashPaid < totalAmount)
                {
                    MessageBox.Show("Insufficient cash provided.", "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal change = cashPaid - totalAmount;
                changeLBL.Text = change.ToString("N2");

                var productRepo = new ProductRepository(); // implements IProductRepository
                var transactionRepo = new TransactionRepository(SQLQuery.connectionString);
                var transactionDetailRepo = new TransactionDetailRepository(SQLQuery.connectionString);

                string refId = "C" + DateTime.Now.ToString("yyMMddHHmmss") + new Random().Next(1000, 9999);

                bool hasOOS = false;

                foreach (DataRow row in _transaction.CartItems.Rows)
                {
                    int productId = Convert.ToInt32(row["ID"]);
                    int quantityInCart = Convert.ToInt32(row["Quantity"]);

                    // Get product info including CategoryID and current Quantity
                    var product = await productRepo.GetByIdAsync(productId);

                    int availableStock = product.Quantity;
                    int categoryId = product.CategoryID;

                    int completedQty = 0;
                    int oosQty = 0;

                    // Determine how many can be completed vs out-of-stock
                    if (categoryId == 3) // Meals exempt
                    {
                        completedQty = Math.Min(quantityInCart, availableStock);
                        oosQty = quantityInCart - completedQty;
                    }
                    else
                    {
                        if (quantityInCart > availableStock)
                        {
                            MessageBox.Show($"'{product.ProductName}' exceeds available stock ({availableStock}).", "Stock Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        completedQty = quantityInCart;
                    }

                    // Insert completed transactions
                    if (completedQty > 0)
                    {
                        var detail = new TransactionDetail
                        {
                            ReferenceID = refId,
                            ProductID = productId,
                            QuantitySold = completedQty,
                            UnitPrice = Convert.ToDecimal(row["Price"]),
                            Subtotal = Convert.ToDecimal(row["Price"]) * completedQty,
                            Remarks = "Completed"
                        };

                        await transactionDetailRepo.InsertTransactionDetailAsync(detail);
                        await productRepo.DeductStockAsync(productId, completedQty);
                    }

                    // Insert out-of-stock transactions (Meals only)
                    if (oosQty > 0)
                    {
                        var detail = new TransactionDetail
                        {
                            ReferenceID = refId,
                            ProductID = productId,
                            QuantitySold = oosQty,
                            UnitPrice = Convert.ToDecimal(row["Price"]),
                            Subtotal = Convert.ToDecimal(row["Price"]) * oosQty,
                            Remarks = "Out of stock purchase"
                        };

                        await transactionDetailRepo.InsertTransactionDetailAsync(detail);
                        hasOOS = true; // mark header as OOS
                    }
                }

                // Insert master transaction
                var transaction = new Transaction
                {
                    ReferenceID = refId,
                    SaleDate = DateTime.Now,
                    StudentID = null,
                    Username = UserSession.Username,
                    TotalAmount = totalAmount,
                    PaymentMethod = 1, // Cash
                    Remarks = hasOOS ? "Out of stock purchase" : "Completed"
                };

                await transactionRepo.InsertTransactionAsync(transaction);

                string message = hasOOS
                    ? $"Transaction completed with OUT-OF-STOCK items!\nChange: ₱{change:N2}"
                    : $"Transaction completed!\nChange: ₱{change:N2}";

                MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _transaction.CartItems.Clear();
                _posControl.ReloadItems();

                _paymentForm.Close();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error processing cash transaction: " + ex.Message, "Transaction Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateChangeLabel()
        {
            if (decimal.TryParse(cashpaymentTE.Text, out decimal cashPaid))
            {
                decimal change = cashPaid - _transaction.GrandTotal;
                changeLBL.Text = change.ToString("N2");
                changeLBL.ForeColor = change < 0 ? Color.Red : Color.Green;
            }
            else
            {
                changeLBL.Text = "0.00";
                changeLBL.ForeColor = Color.Black;
            }
        }

        private void cashpaymentTE_EditValueChanged(object sender, EventArgs e)
        {
            UpdateChangeLabel();
        }

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
    }
}