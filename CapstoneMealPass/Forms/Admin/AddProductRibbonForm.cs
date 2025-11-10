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
using DevExpress.XtraBars;
using MealPass.Core.Entity;
using MealPass.Core.GlobalSql;
using MealPass.Core.Interface;
using MealPass.Data.Repositories;

namespace CapstoneMealPass.Forms.Admin
{
    public partial class AddProductRibbonForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private readonly IProductRepository _productRepository = new ProductRepository();

        public event EventHandler ProductAdded;

        public AddProductRibbonForm()
        {
            InitializeComponent();
        }

        private async void addproductBTN_Click(object sender, EventArgs e)
        {
            var product = new Product
            {
                ProductName = productnameTE.Text.Trim(),
                CategoryID = categoryCBE.SelectedIndex + 1,
                Price = int.Parse(priceTE.Text),
                Quantity = int.Parse(quantityTE.Text),
                LowStockLevel = int.Parse(lowstocklevelTE.Text)
            };

            await _productRepository.AddAsync(product);
            await GlobalLogger.EmployeeLogAsync($"{UserSession.Username} added a product.", UserSession.Username);
            MessageBox.Show("✅ Product added successfully!");

            ProductAdded?.Invoke(this, EventArgs.Empty);

            ClearAll();
        }

        private void ClearAll()
        {
            productnameTE.Text = string.Empty;
            priceTE.Text = string.Empty;
            quantityTE.Text = string.Empty;
            lowstocklevelTE.Text = string.Empty;

            categoryCBE.SelectedIndex = -1;

            productnameTE.Focus();
        }
    }
}