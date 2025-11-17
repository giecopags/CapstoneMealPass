using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using MealPass.Core.Interface;
using MealPass.Data.Repositories;

namespace CapstoneMealPass.Forms.Admin
{
    public partial class ProductsUserControl : DevExpress.XtraEditors.XtraUserControl
    {
        private readonly IProductRepository _productRepository = new ProductRepository();

        public ProductsUserControl()
        {
            InitializeComponent();
            LoadProducts();
        }

        private async void LoadProducts()
        {
            try
            {
                var productsTable = await _productRepository.GetAllWithDetailsAsync();

                if (productsTable.Rows.Count == 0)
                {
                    MessageBox.Show("⚠️ No products found.");
                }

                gcProducts.DataSource = productsTable;
                // Format the Price column to N2
                gvProducts.Columns["Price"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                gvProducts.Columns["Price"].DisplayFormat.FormatString = "N2";
                gvProducts.BestFitColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Failed to load products: " + ex.Message);
            }
        }

        private void addproductBTN_Click(object sender, EventArgs e)
        {
            var form = new AddProductRibbonForm();
            form.ProductAdded += (s, args) =>
            {
                LoadProducts(); 
            };

            Helpers.FormHelper.DisplayForm(form);
        }

        private void findTE_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            gvProducts.ApplyFindFilter(e.NewValue as string);
        }

        private void gvProducts_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            var selectedProductID = gvProducts.GetRowCellValue(e.RowHandle, "ProductID");

            if (selectedProductID != null && int.TryParse(selectedProductID.ToString(), out int productId))
            {
                using (var editForm = new EditProductRibbonForm(productId))
                {
                    editForm.ShowDialog();
                }

                LoadProducts();
            }
            else
            {
                MessageBox.Show("⚠️ Unable to get the selected Product ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void gvProducts_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;

            if (e.Column.FieldName == "StockStatusName" && e.RowHandle >= 0)
            {
                var stockStatusObj = view.GetRowCellValue(e.RowHandle, "StockStatusName");
                if (stockStatusObj == null)
                    return;

                string stockStatus = stockStatusObj.ToString();

                if (stockStatus == "In Stock")
                {
                    e.Appearance.ForeColor = Color.Green;
                }
                else if (stockStatus == "Low Stock")
                {
                    e.Appearance.ForeColor = Color.Orange;
                }
                else if (stockStatus == "Out Of Stock")
                {
                    e.Appearance.ForeColor = Color.IndianRed;
                }
            }
        }
    }
}
