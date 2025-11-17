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
using MealPass.Core.GlobalSql;
using MealPass.Core.Interface;
using MealPass.Data.Repositories;

namespace CapstoneMealPass.Forms.Admin
{
    public partial class SalesUserControl : DevExpress.XtraEditors.XtraUserControl
    {
        private readonly ISaleRepository _salesRepo;
        public SalesUserControl()
        {
            InitializeComponent();
            string connectionString = SQLQuery.connectionString;
            _salesRepo = new SaleRepository(connectionString);
        }

        private async void dateDE_EditValueChanged(object sender, EventArgs e)
        {
            if (dateDE.EditValue == null)
            {
                await LoadAllSalesAsync();
                return;
            }

            DateTime date = Convert.ToDateTime(dateDE.EditValue);
            await LoadSalesByDateAsync(date);
        }

        private async void SalesUserControl_Load(object sender, EventArgs e)
        {
            await LoadAllSalesAsync();
        }

        private async Task LoadAllSalesAsync()
        {
            try
            {
                var sales = await _salesRepo.GetAllSalesSummaryAsync();

                gcSales.DataSource = sales.Select(x => new
                {
                    x.ProductName,
                    x.CategoryName,
                    UnitPrice = x.UnitPrice.ToString("N2"),
                    x.ItemSold,
                    TotalAmount = x.TotalAmount.ToString("N2")
                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load sales summary: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task LoadSalesByDateAsync(DateTime date)
        {
            try
            {
                var sales = await _salesRepo.GetSalesSummaryByDateAsync(date);

                gcSales.DataSource = sales.Select(x => new
                {
                    x.ProductName,
                    x.CategoryName,
                    UnitPrice = x.UnitPrice.ToString("N2"),
                    x.ItemSold,
                    TotalAmount = x.TotalAmount.ToString("N2")
                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load filtered sales: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void findTE_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            gvSales.ApplyFindFilter(e.NewValue as string);
        }
    }
}
