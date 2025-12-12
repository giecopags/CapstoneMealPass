using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using MealPass.Core.GlobalSql;
using MealPass.Core.Interface;
using MealPass.Data.Queries;
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

        private async Task LoadSalesByRangeAsync(DateTime from, DateTime to)
        {
            var sales = await _salesRepo.GetSalesSummaryByDateTimeRangeAsync(from, to);

            gcSales.DataSource = sales.Select(x => new
            {
                x.ProductID,
                x.ProductName,
                x.CategoryName,
                UnitPrice = x.UnitPrice.ToString("N2"),
                x.ItemSold,
                TotalAmount = x.TotalAmount.ToString("N2")
            }).ToList();
        }
      
        private void findTE_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            gvSales.ApplyFindFilter(e.NewValue as string);
        }

        private void printBTN_Click(object sender, EventArgs e)
        {
            if (fromDateDE.EditValue == null || toDateDE.EditValue == null)
                return;

            DateTime from = Convert.ToDateTime(fromDateDE.EditValue).Date;
            DateTime to = Convert.ToDateTime(toDateDE.EditValue).Date.AddDays(1).AddSeconds(-1);

            var report = new Reports.DailySalesXtraReport();

            using (var connection = new SqlConnection(SQLQuery.connectionString))
            {
                using (var command = new SqlCommand(SaleQuery.GetSalesSummaryByDateTimeRange, connection))
                {
                    command.Parameters.AddWithValue("@FromDateTime", from);
                    command.Parameters.AddWithValue("@ToDateTime", to);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        report.DataSource = dt;

                        if (from.Date == to.Date.Date)
                            report.xrLabel3.Text = from.ToString("MMMM dd, yyyy");
                        else
                            report.xrLabel3.Text = $"{from:MMMM dd, yyyy} - {to:MMMM dd, yyyy}";

                        report.CreateDocument();
                        new ReportPrintTool(report).ShowPreviewDialog();
                    }
                }
            }
        }

        private async void filterBTN_Click(object sender, EventArgs e)
        {
            if (fromDateDE.EditValue == null || toDateDE.EditValue == null)
            {
                MessageBox.Show("Please select both From and To dates.", "Invalid Date Range",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool isFromValid = DateTime.TryParse(fromDateDE.EditValue.ToString(), out DateTime from);
            bool isToValid = DateTime.TryParse(toDateDE.EditValue.ToString(), out DateTime to);

            if (!isFromValid || !isToValid)
            {
                MessageBox.Show("Selected dates are invalid. Please select valid dates.", "Invalid Date Range",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (from > to)
            {
                MessageBox.Show("'From' date cannot be after 'To' date.", "Invalid Date Range",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime toInclusive = to.Date.AddDays(1).AddTicks(-1);

            await LoadSalesByRangeAsync(from, toInclusive);
        }

        public async Task LoadSalesTodayAsync()
        {
            DateTime from = DateTime.Today;
            DateTime to = DateTime.Today.AddDays(1).AddSeconds(-1); 

            var sales = await _salesRepo.GetSalesSummaryByDateTimeRangeAsync(from, to);

            gcSales.DataSource = sales.Select(x => new
            {
                x.ProductID,
                x.ProductName,
                x.CategoryName,
                UnitPrice = x.UnitPrice.ToString("N2"),
                x.ItemSold,
                TotalAmount = x.TotalAmount.ToString("N2")
            }).ToList();
        }

        private async void SalesUserControl_Load(object sender, EventArgs e)
        {
            await LoadSalesTodayAsync();
        }
    }
}



