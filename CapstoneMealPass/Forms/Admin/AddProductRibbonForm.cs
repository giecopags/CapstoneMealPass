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
            if (string.IsNullOrWhiteSpace(productnameTE.Text) ||
                categoryCBE.SelectedIndex < 0 ||
                string.IsNullOrWhiteSpace(priceTE.Text) ||
                string.IsNullOrWhiteSpace(quantityTE.Text) ||
                string.IsNullOrWhiteSpace(lowstocklevelTE.Text))
            {
                MessageBox.Show("⚠ Please fill in all fields before adding the product.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(priceTE.Text, out int price) ||
                !int.TryParse(quantityTE.Text, out int quantity) ||
                !int.TryParse(lowstocklevelTE.Text, out int lowStock))
            {
                MessageBox.Show("⚠ Price, Quantity, and Low Stock Level must be valid numbers.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var product = new Product
            {
                ProductName = productnameTE.Text.Trim(),
                CategoryID = categoryCBE.SelectedIndex + 1,
                Price = price,
                Quantity = quantity,
                LowStockLevel = lowStock
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