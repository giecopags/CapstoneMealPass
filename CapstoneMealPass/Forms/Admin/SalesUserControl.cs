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
using DevExpress.XtraSplashScreen;
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
                x.Remarks,
                TotalAmount = x.TotalAmount.ToString("N2")
            }).ToList();
        }
      
        private void findTE_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            gvSales.ApplyFindFilter(e.NewValue as string);
        }

        private async void printBTN_Click(object sender, EventArgs e)
        {
            if (fromDateDE.EditValue == null && toDateDE.EditValue != null)
            {
                MessageBox.Show("Please select a 'From' date when 'To' date is selected.",
                                "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime from, to;

            if (fromDateDE.EditValue == null && toDateDE.EditValue == null)
            {
                DateTime now = DateTime.Now;
                from = now.Date;
                to = now.Date.AddDays(1).AddSeconds(-1);
            }
            else
            {
                from = fromDateDE.EditValue == null
                    ? DateTime.Now.Date
                    : Convert.ToDateTime(fromDateDE.EditValue).Date;

                to = toDateDE.EditValue == null
                    ? DateTime.Now.Date.AddDays(1).AddSeconds(-1)
                    : Convert.ToDateTime(toDateDE.EditValue).Date.AddDays(1).AddSeconds(-1);
            }

            Form parentForm = this.FindForm();

            SplashScreenManager.ShowForm(
                parentForm,
                typeof(SplashScreen),
                true,
                true
            );

            await Task.Run(() =>
            {
                var report = new Reports.DailySalesXtraReport();

                using (var connection = new SqlConnection(SQLQuery.connectionString))
                using (var command = new SqlCommand(SaleQuery.GetSalesSummaryByDateTimeRange, connection))
                {
                    command.Parameters.AddWithValue("@FromDateTime", from);
                    command.Parameters.AddWithValue("@ToDateTime", to);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        report.DataSource = dt;

                        if (from.Date == to.Date)
                            report.xrLabel3.Text = from.ToString("MMMM dd, yyyy");
                        else
                            report.xrLabel3.Text = $"{from:MMMM dd, yyyy} - {to:MMMM dd, yyyy}";

                        report.CreateDocument();

                        this.Invoke(new Action(() =>
                        {
                            new ReportPrintTool(report).ShowPreviewDialog();
                        }));
                    }
                }
            });

            if (SplashScreenManager.Default.IsSplashFormVisible)
                SplashScreenManager.CloseForm();
        }

        private async void filterBTN_Click(object sender, EventArgs e)
        {
            DateTime from, to;
            if (fromDateDE.EditValue == null && toDateDE.EditValue != null)
            {
                MessageBox.Show("Please select a 'From' date when 'To' date is selected.",
                                "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            from = fromDateDE.EditValue == null
                ? DateTime.Today
                : Convert.ToDateTime(fromDateDE.EditValue).Date;

            to = toDateDE.EditValue == null
                ? DateTime.Today.AddDays(1).AddSeconds(-1) 
                : Convert.ToDateTime(toDateDE.EditValue).Date.AddDays(1).AddSeconds(-1);

            if (from > to)
            {
                MessageBox.Show("'From' date cannot be after 'To' date.", "Invalid Date Range",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            await LoadSalesByRangeAsync(from, to);
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
                x.Remarks,
                TotalAmount = x.TotalAmount.ToString("N2")
            }).ToList();
        }

        private async void SalesUserControl_Load(object sender, EventArgs e)
        {
            await LoadSalesTodayAsync();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Check if Ctrl+P is pressed
            if (keyData == (Keys.Control | Keys.P))
            {
                // Call your existing print method
                printBTN_Click(this, EventArgs.Empty);
                return true; // Indicate that the key was handled
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
