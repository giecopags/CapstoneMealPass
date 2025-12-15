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
    public partial class DashboarddUserControl : DevExpress.XtraEditors.XtraUserControl
    {
        private readonly IDashboardRepository _dashboardRepo;
        public DashboarddUserControl()
        {
            InitializeComponent();

            _dashboardRepo = new DashboardRepository(SQLQuery.connectionString);

            this.Load += DashboarddUserControl_Load;
            dateDE.EditValueChanged += dateDE_EditValueChanged;
        }

        private async void DashboarddUserControl_Load(object sender, EventArgs e)
        {
            dateDE.EditValue = DateTime.Now;
            await LoadStockCountersAsync();
            await LoadChartAsync();
            await LoadBestSellerChart(DateTime.Now.Month, DateTime.Now.Year);
        }

        private async Task LoadChartAsync()
        {
            try
            {
                var data = await _dashboardRepo.GetMonthlySummaryAsync();

                ccTotalSale.DataSource = data;

                // Series mapping already done in Designer:
                // Series 1 → TotalSale
                // Series 2 → TotalTopUp
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load chart data: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadBestSellerChart(int month, int year)
        {
            try
            {
                var data = await _dashboardRepo.GetTopBestSellersByMonthAsync(month, year);

                ccBestSeller.DataSource = data;


                var series = ccBestSeller.Series[0];
                series.ArgumentDataMember = "ProductName";
                series.ValueDataMembers[0] = "TotalQuantitySold";

                // Custom Hover Tooltip
                series.ToolTipPointPattern =
                    "Product: {A}\nSold: {V} pcs\nTotal Sales: ₱{TotalAmount}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load best sellers: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadStockCountersAsync()
        {
            try
            {
                int lowStock = await _dashboardRepo.GetLowStockCountAsync();
                int outOfStock = await _dashboardRepo.GetOutOfStockCountAsync();

                lcLowStock.Text = lowStock.ToString();
                lcOutOfStock.Text = outOfStock.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load stock counters: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void dateDE_EditValueChanged(object sender, EventArgs e)
        {
            if (dateDE.EditValue == null)
                return;

            DateTime dt = Convert.ToDateTime(dateDE.EditValue);

            await LoadBestSellerChart(dt.Month, dt.Year);
        }
    }
}
