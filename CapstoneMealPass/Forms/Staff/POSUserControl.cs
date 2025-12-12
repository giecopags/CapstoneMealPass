using CapstoneMealPass.Helpers;
using DevExpress.XtraEditors;
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
    public partial class POSUserControl : DevExpress.XtraEditors.XtraUserControl
    {
        private readonly ProductRepository _productRepo = new ProductRepository();


        public POSUserControl()
        {
            InitializeComponent();
            Cancel.ColumnEdit = repositoryItemCancelBTN;
            findTE.KeyDown += findTE_KeyDown;
            productsGV.KeyDown += productsGV_KeyDown;
            cartGV.KeyDown += cartGV_KeyDown;
            this.Load += PosUC_LoadAsync;
        }

        private async void PosUC_LoadAsync(object sender, EventArgs e)
        {
            await LoadProductsAsync();

            productsGV.Columns["Price"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            productsGV.Columns["Price"].DisplayFormat.FormatString = "N2";

            productsGV.OptionsBehavior.Editable = false;
            productsGV.OptionsSelection.EnableAppearanceFocusedRow = true;
            productsGV.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            productsGV.OptionsSelection.MultiSelect = false;
            productsGV.OptionsBehavior.FocusLeaveOnTab = true;
            productsGV.OptionsSelection.EnableAppearanceFocusedCell = true;
        }

        private async Task LoadSnacksAsync()
        {
            var dataTable = await _productRepo.LoadSnacksAsync();
            productsGC.DataSource = dataTable;
        }

        private async Task LoadMealsAsync()
        {
            var dataTable = await _productRepo.LoadMealsAsync();
            productsGC.DataSource = dataTable;
        }

        private async Task LoadProductsAsync()
        {
            var dataTable = await _productRepo.LoadProductsAsync();
            productsGC.DataSource = dataTable;
        }

        private async Task LoadDrinksAsync()
        {
            var dataTable = await _productRepo.LoadDrinksAsync();
            productsGC.DataSource = dataTable;
        }

        private void addtocartBTN_Click(object sender, EventArgs e)
        {
            int selectedRow = productsGV.FocusedRowHandle;
            if (selectedRow < 0)
            {
                MessageBox.Show("Please select a product first.");
                return;
            }

            string productID = productsGV.GetRowCellValue(selectedRow, "ProductID")?.ToString();
            string productName = productsGV.GetRowCellValue(selectedRow, "ProductName")?.ToString();
            string priceStr = productsGV.GetRowCellValue(selectedRow, "Price")?.ToString();
            string stockStr = productsGV.GetRowCellValue(selectedRow, "Quantity")?.ToString();
            string categoryStr = productsGV.GetRowCellValue(selectedRow, "CategoryID")?.ToString();
            string categoryName = productsGV.GetRowCellValue(selectedRow, "CategoryName")?.ToString();

            int stock = int.TryParse(stockStr, out int s) ? s : 0;
            int categoryID = int.TryParse(categoryStr, out int c) ? c : 0;

            // Meals 0 stock logic
            if (stock <= 0)
            {
                if (categoryName == "Meals")
                {
                    MessageBox.Show(
                        $"Warning: '{productName}' has 0 stock but is allowed for sale.",
                        "Zero Stock Allowed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
                else
                {
                    MessageBox.Show(
                        $"Sorry, '{productName}' is out of stock.",
                        "Out of Stock",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }
            }

            decimal price = decimal.TryParse(priceStr, out decimal p) ? p : 0;
            int quantity = 1; // default quantity
            decimal total = price * quantity;

            DataTable cartTable = cartGC.DataSource as DataTable;
            if (cartTable == null)
            {
                cartTable = new DataTable();
                cartTable.Columns.Add("ID");
                cartTable.Columns.Add("ProductName");
                cartTable.Columns.Add("Quantity", typeof(int));
                cartTable.Columns.Add("Price", typeof(decimal));
                cartTable.Columns.Add("Total", typeof(decimal));
                cartGC.DataSource = cartTable;

                cartGV.Columns["Price"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                cartGV.Columns["Price"].DisplayFormat.FormatString = "N2";

                cartGV.Columns["Total"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                cartGV.Columns["Total"].DisplayFormat.FormatString = "N2";

                cartGV.BestFitColumns();
            }

            bool alreadyInCart = cartTable.AsEnumerable().Any(r => r["ID"].ToString() == productID);
            if (alreadyInCart)
            {
                MessageBox.Show($"'{productName}' is already in your cart.", "Duplicate Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataRow newRow = cartTable.NewRow();
            newRow["ID"] = productID;
            newRow["ProductName"] = productName;
            newRow["Quantity"] = quantity;
            newRow["Price"] = price;
            newRow["Total"] = total;
            cartTable.Rows.Add(newRow);

            UpdateTotalAmount(cartTable);
        }

        private void UpdateTotalAmount(DataTable cartTable)
        {
            decimal sum = 0;
            foreach (DataRow row in cartTable.Rows)
            {
                if (decimal.TryParse(row["Total"]?.ToString(), out decimal total))
                {
                    sum += total;
                }
            }
            grandtotalLBL.Text = sum.ToString("N2");
        }

        private void cartGV_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "Quantity" || e.Column.FieldName == "Price")
            {
                int rowHandle = e.RowHandle;
                object quantityObj = cartGV.GetRowCellValue(rowHandle, "Quantity");
                object priceObj = cartGV.GetRowCellValue(rowHandle, "Price");

                if (int.TryParse(quantityObj?.ToString(), out int quantity) &&
                    decimal.TryParse(priceObj?.ToString(), out decimal price))
                {
                    decimal total = quantity * price;
                    cartGV.SetRowCellValue(rowHandle, "Total", total);

                    if (cartGC.DataSource is DataTable cartTable)
                    {
                        UpdateTotalAmount(cartTable);
                    }
                }
            }
        }

        private void repositoryItemCancelBTN_Click(object sender, EventArgs e)
        {
            var editor = sender as DevExpress.XtraEditors.ButtonEdit;
            if (editor == null) return;

            var view = cartGV;
            int rowHandle = view.FocusedRowHandle;
            if (rowHandle < 0) return;

            string id = view.GetRowCellValue(rowHandle, "ID")?.ToString();
            if (string.IsNullOrEmpty(id)) return;

            if (cartGC.DataSource is DataTable cartTable)
            {

                var rowsToRemove = cartTable.AsEnumerable()
                    .Where(r => r["ID"].ToString() == id)
                    .ToList();

                int deletedCount = rowsToRemove.Count;

                foreach (var row in rowsToRemove)
                    cartTable.Rows.Remove(row);

                UpdateTotalAmount(cartTable);
                view.RefreshData();
            }
        }

        private void confirmBTN_Click(object sender, EventArgs e)
        {
            if (!ValidateCartStock(out string errorMessage))
            {
                MessageBox.Show(errorMessage, "Stock Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Stop checkout
            }

            var cartTable = cartGC.DataSource as DataTable;
            if (cartTable == null || cartTable.Rows.Count == 0)
            {
                MessageBox.Show("Cart is empty. Cannot proceed to checkout.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Parse Grand Total
            if (!decimal.TryParse(grandtotalLBL.Text, out var grandTotal))
            {
                MessageBox.Show("Invalid total amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Build TransactionData object
            var transactionData = new MealPass.Core.Entity.TransactionData
            {
                CartItems = cartTable.Copy(), // Copy to avoid modifying original
                GrandTotal = grandTotal,
                Username = UserSession.Username, // or your logged-in staff name
                TransactionDateTime = DateTime.Now
            };

            // Pass it to the PaymentOptionXtraForm
            var paymentForm = new Staff.PaymentOptionXtraForm(transactionData,this);
            FormHelper.DisplayForm(paymentForm);
        }

        private async void snacksBTN_Click(object sender, EventArgs e)
        {
            await LoadSnacksAsync();
        }

        private async void mealsBTN_Click(object sender, EventArgs e)
        {
            await LoadMealsAsync();
        }

        private async void drinksBTN_Click(object sender, EventArgs e)
        {
            await LoadDrinksAsync();
        }

        private async void allBTN_Click(object sender, EventArgs e)
        {
            await LoadProductsAsync();
        }

        private void findTE_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            productsGV.ApplyFindFilter(e.NewValue as string);
        }

        public async void ReloadItems()
        {
            await LoadProductsAsync();  // refresh product list
            cartGC.DataSource = null; // reset cart
            grandtotalLBL.Text = "0.00";
        }

        private bool ValidateCartStock(out string errorMessage)
        {
            errorMessage = string.Empty;

            // Get the products data source
            DataTable productsTable = productsGC.DataSource as DataTable;
            if (productsTable == null) return true; // No products loaded

            DataTable cartTable = cartGC.DataSource as DataTable;
            if (cartTable == null || cartTable.Rows.Count == 0) return true; // Cart empty

            foreach (DataRow cartRow in cartTable.Rows)
            {
                string productId = cartRow["ID"].ToString();
                int cartQuantity = Convert.ToInt32(cartRow["Quantity"]);

                // Lookup product in productsGC table
                DataRow productRow = productsTable.AsEnumerable()
                    .FirstOrDefault(r => r["ProductID"].ToString() == productId);

                if (productRow == null) continue; // Product not found

                int stock = Convert.ToInt32(productRow["Quantity"]);
                string category = productRow["CategoryName"].ToString();

                // Skip check for Meals category
                if (category.Equals("Meals", StringComparison.OrdinalIgnoreCase))
                    continue;

                if (cartQuantity > stock)
                {
                    errorMessage = $"'{cartRow["ProductName"]}' exceeds available stock ({stock}).";
                    return false;
                }
            }

            return true;
        }

        private void FocusProductGrid()
        {
            productsGC.Focus();
            productsGV.Focus();

            if (productsGV.RowCount > 0)
            {
                productsGV.FocusedRowHandle = 0;         
                productsGV.SelectRow(0);                 
            }
        }

        private void FocusCartGridAndEditQty()
        {
            try
            {
                if (cartGC == null || cartGV == null)
                    return;

                // Move focus to the Cart GridControl
                cartGC.Focus();

                // If there are no items, stop
                if (cartGV.RowCount == 0)
                    return;

                // Select the first visible row if nothing is selected
                if (cartGV.FocusedRowHandle < 0)
                {
                    int firstVisible = cartGV.GetVisibleRowHandle(0);
                    cartGV.FocusedRowHandle = firstVisible;
                }

                // Focus the Quantity column
                cartGV.FocusedColumn = cartGV.Columns["Quantity"];

                // Make sure the row is visible
                cartGV.MakeRowVisible(cartGV.FocusedRowHandle);

                // Open the SpinEdit editor
                cartGV.ShowEditor();
            }
            catch { }
        }

        public bool HandleShortcut(Keys keyData)
        {
            // CTRL + F → focus search
            if (keyData == (Keys.Control | Keys.F))
            {
                findTE.Focus();
                findTE.SelectAll();
                return true;
            }

            // ENTER → Add to cart
            if (keyData == Keys.Enter)
            {
                if (productsGV.FocusedRowHandle >= 0)
                {
                    addtocartBTN_Click(null, null);
                    return true;
                }
            }

            // DOWN ARROW → move from search to product list
            if (keyData == Keys.Down)
            {
                if (findTE.Focused)
                {
                    FocusProductGrid();
                    return true;
                }
            }

            if (keyData == (Keys.Control | Keys.C))
            {
                FocusCartGridAndEditQty();
                return true;
            }

            // BACKSPACE → delete product from cart
            if (keyData == Keys.Back && cartGV.FocusedRowHandle >= 0)
            {
                if (cartGV != null && cartGV.FocusedRowHandle >= 0)
                {
                    // Confirm deletion (optional)
                    DialogResult result = MessageBox.Show(
                        "Delete selected product from cart?",
                        "Confirm Delete",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (result == DialogResult.Yes)
                    {
                        cartGV.DeleteRow(cartGV.FocusedRowHandle);
                    }
                }
                return true;
            }

            // CTRL + 1 → Snacks
            if (keyData == (Keys.Control | Keys.D1))
            {
                snacksBTN_Click(null, null);
                return true;
            }

            // CTRL + 2 → Meals
            if (keyData == (Keys.Control | Keys.D2))
            {
                mealsBTN_Click(null, null);
                return true;
            }

            // CTRL + 3 → Drinks
            if (keyData == (Keys.Control | Keys.D3))
            {
                drinksBTN_Click(null, null);
                return true;
            }

            // CTRL + 4 → All Products
            if (keyData == (Keys.Control | Keys.D4))
            {
                allBTN_Click(null, null);
                return true;
            }

            // CTRL + ENTER → Confirm checkout
            if (keyData == (Keys.Control | Keys.Enter))
            {
                confirmBTN_Click(null, null);
                return true;
            }


            return false;
        }

        private void findTE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                e.Handled = true;
                FocusProductGrid();
            }
        }

        private void productsGV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                addtocartBTN_Click(this, EventArgs.Empty);
            }
        }

        private void cartGV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;

                cartGV.FocusedColumn = cartGV.Columns["Quantity"];
                cartGV.ShowEditor();
            }
        }
    }
}
