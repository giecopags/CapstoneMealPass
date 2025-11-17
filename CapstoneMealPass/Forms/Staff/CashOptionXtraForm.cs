using CapstoneMealPass.Helpers;
using DevExpress.XtraEditors;
using MealPass.Core.Entity;
using MealPass.Core.GlobalSql;
using MealPass.Data;
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
                // Validate input
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

                // Initialize repositories
                string connectionString = SQLQuery.connectionString;
                var transactionRepo = new TransactionRepository(connectionString);
                var transactionDetailRepo = new TransactionDetailRepository(connectionString);
                var productRepo = new ProductRepository();

                // Generate Reference ID
                string refId = "C" + DateTime.Now.ToString("yyMMddHHmmss") + new Random().Next(1000, 9999);

                // Create and insert master transaction
                var transaction = new Transaction
                {
                    ReferenceID = refId,
                    SaleDate = DateTime.Now,
                    StudentID = null, // Cash transaction, no student
                    Username = UserSession.Username,
                    TotalAmount = totalAmount,
                    PaymentMethod = 1, // 1 = Cash
                    Remarks = "Completed"
                };

                await transactionRepo.InsertTransactionAsync(transaction);

                // Insert transaction details and deduct stock
                foreach (DataRow row in _transaction.CartItems.Rows)
                {
                    int productId = Convert.ToInt32(row["ID"]);
                    int quantity = Convert.ToInt32(row["Quantity"]);

                    var detail = new TransactionDetail
                    {
                        ReferenceID = refId,
                        ProductID = productId,
                        QuantitySold = quantity,
                        UnitPrice = Convert.ToDecimal(row["Price"]),
                        Subtotal = Convert.ToDecimal(row["Total"])
                    };

                    await transactionDetailRepo.InsertTransactionDetailAsync(detail);
                    await productRepo.DeductStockAsync(productId, quantity);
                }

                // Success Message
                MessageBox.Show($"Transaction completed!\nChange: ₱{change:N2}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear cart and refresh POS
                _transaction.CartItems.Clear();
                _posControl.ReloadItems();

                // Close all related forms
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
    }
}