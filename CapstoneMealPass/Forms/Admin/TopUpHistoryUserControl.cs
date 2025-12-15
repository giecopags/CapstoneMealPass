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
using MealPass.Core.Entity;
using MealPass.Core.GlobalSql;
using MealPass.Core.Interface;
using MealPass.Data.Queries;
using MealPass.Data.Repositories;

namespace CapstoneMealPass.Forms.Admin
{
    public partial class TopUpHistoryUserControl : DevExpress.XtraEditors.XtraUserControl
    {
        private readonly ITopUpLogRepository _logRepo;

        public TopUpHistoryUserControl()
        {
            InitializeComponent();

            string connectionString = SQLQuery.connectionString;
            _logRepo = new TopUpLogRepository(connectionString);

            this.Load += TopUpHistoryUserControl_Load;
        }

        private async void TopUpHistoryUserControl_Load(object sender, EventArgs e)
        {
            await LoadTopUpHistoryTodayAsync();
        }

        private async Task LoadTopUpLogsByRangeAsync(DateTime from, DateTime to)
        {
            DateTime toInclusive = to.Date.AddDays(1).AddTicks(-1);

            var logs = await _logRepo.LoadTopUpLogsByDateRangeAsync(from, toInclusive);

            gcTopUp.DataSource = logs.Select(x => new
            {
                x.TopUpID,
                x.StudentID,
                x.Username,
                Amount = x.Amount.ToString("N2"),
                TopUpDate = x.TopUpDate.ToString("MM/dd/yyyy hh:mm tt"),
                x.Status
            }).ToList();

            gvTopUp.BestFitColumns();
        }
        public async Task LoadTopUpHistoryTodayAsync()
        {
            DateTime today = DateTime.Today;

            var logs = await _logRepo.LoadTopUpLogsByDateAsync(today);

            var formatted = logs.Select(x => new
            {
                x.TopUpID,
                x.StudentID,
                x.Username,
                Amount = x.Amount.ToString("N2"),
                TopUpDate = x.TopUpDate.ToString("dd/MM/yy hh:mm tt"),
                x.Status
            }).ToList();

            gcTopUp.DataSource = formatted;
        }

        private void findTE_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            gvTopUp.ApplyFindFilter(e.NewValue as string);
        }

        private async void printBTN_Click(object sender, EventArgs e)
        {
            if (fromDateDE.EditValue == null || toDateDE.EditValue == null)
            {
                MessageBox.Show("Please select a date range before printing.",
                    "No Date Range", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime from = Convert.ToDateTime(fromDateDE.EditValue).Date;
            DateTime to = Convert.ToDateTime(toDateDE.EditValue).Date.AddDays(1).AddSeconds(-1);

            Form parentForm = this.FindForm();

            SplashScreenManager.ShowForm(
                parentForm,
                typeof(SplashScreen),
                true,
                true
            );

            await Task.Run(() =>
            {
                Reports.TopUpHistoryXtraReport report = new Reports.TopUpHistoryXtraReport();

                using (var connection = new SqlConnection(SQLQuery.connectionString))
                {
                    string query = TopUpLogQuery.GetTopUpLogsByDateRange;

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FromDate", from);
                        command.Parameters.AddWithValue("@ToDate", to);

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

            });

            if (SplashScreenManager.Default.IsSplashFormVisible)
                SplashScreenManager.CloseForm();
        }

        private async void filterBTN_Click(object sender, EventArgs e)
        {
            if (fromDateDE.EditValue == null || toDateDE.EditValue == null)
            {
                MessageBox.Show("Please select both dates.", "Invalid Date Range",
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

            await LoadTopUpLogsByRangeAsync(from, to);
        }
    }
}
