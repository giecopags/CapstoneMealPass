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
using Dapper;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using DevExpress.XtraSplashScreen;
using MealPass.Core.GlobalSql;

namespace CapstoneMealPass.Forms.Admin
{
    public partial class EmployeeLogsUserControl : DevExpress.XtraEditors.XtraUserControl
    {
        public EmployeeLogsUserControl()
        {
            InitializeComponent();
        }

        private async Task LoadLogsByRangeAsync(DateTime from, DateTime to)
        {
            using (var connection = new SqlConnection(SQLQuery.connectionString))
            {
                string query = @"
                                SELECT 
                                    el.LogID, 
                                    el.Username,
                                    el.DateTime, 
                                    el.Activity,
                                    el.Authentication
                                FROM dbo.EmployeeLogs el
                                WHERE el.DateTime >= @FromDate AND el.DateTime < @ToDate
                                ORDER BY el.LogID DESC";

                await connection.OpenAsync();

                using (var cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@FromDate", from.Date);
                    cmd.Parameters.AddWithValue("@ToDate", to.Date.AddDays(1));

                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        var dt = new DataTable();
                        dt.Load(reader);
                        gcEmployeeLogs.DataSource = dt;
                    }
                }

                if (gcEmployeeLogs.MainView is GridView view)
                {
                    view.Columns["DateTime"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                    view.Columns["DateTime"].DisplayFormat.FormatString = "MM/dd/yyyy hh:mm tt";
                    view.BestFitColumns();
                }
            }
        }

        private async void printBTN_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            DateTime from, to;

            if (fromDateDE.EditValue == null && toDateDE.EditValue != null)
            {
                MessageBox.Show("Please select a 'From' date when 'To' date is selected.",
                                "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            if (fromDateDE.EditValue == null)
                from = System.DateTime.Today;
            else if (!System.DateTime.TryParse(fromDateDE.EditValue.ToString(), out from))
            {
                MessageBox.Show("Selected 'From' date is invalid.", "Invalid Date",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            from = from.Date;

            // Parse To date
            if (toDateDE.EditValue == null)
                to = System.DateTime.Today.AddDays(1).AddSeconds(-1);
            else if (!System.DateTime.TryParse(toDateDE.EditValue.ToString(), out to))
            {
                MessageBox.Show("Selected 'To' date is invalid.", "Invalid Date",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            to = to.Date.AddDays(1).AddSeconds(-1);

            // Validate range
            if (from > to)
            {
                MessageBox.Show("'From' date cannot be after 'To' date.", "Invalid Date Range",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            SplashScreenManager.ShowForm(
                parentForm,
                typeof(SplashScreen),
                true,
                true
            );

            await Task.Run(() =>
            {
                var report = new Reports.EmployeeLogsXtraReport();
                DataTable dt = gcEmployeeLogs.DataSource as DataTable;
                report.DataSource = dt;

                report.xrLabel3.Text = from.Date == to.Date
                    ? from.ToString("MMMM dd, yyyy")
                    : $"{from:MMMM dd, yyyy} - {to:MMMM dd, yyyy}";

                report.CreateDocument();

                parentForm.Invoke(new Action(() =>
                {
                    new ReportPrintTool(report).ShowPreviewDialog();
                }));
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
                ? System.DateTime.Today
                : Convert.ToDateTime(fromDateDE.EditValue).Date;

            to = toDateDE.EditValue == null
                ? System.DateTime.Today.AddDays(1).AddSeconds(-1)
                : Convert.ToDateTime(toDateDE.EditValue).Date.AddDays(1).AddSeconds(-1);

            if (from > to)
            {
                MessageBox.Show("'From' date cannot be after 'To' date.", "Invalid Date Range",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            await LoadLogsByRangeAsync(from, to);
        }

        private async void EmployeeLogsUserControl_Load(object sender, EventArgs e)
        {
            System.DateTime today = System.DateTime.Today;
            await LoadLogsByRangeAsync(today, today);
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
