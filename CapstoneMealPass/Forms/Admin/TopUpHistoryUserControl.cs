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
            await LoadTopUpLogsAsync();
        }

        private async Task LoadTopUpLogsAsync()
        {
            try
            {
                var logs = await _logRepo.LoadTopUpLogsAsync();
                gcTopUp.DataSource = logs;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load top-up logs: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void dateDE_EditValueChanged(object sender, EventArgs e)
        {
            if (dateDE.EditValue == null)
            {
                await LoadTopUpLogsAsync(); // Load all logs if cleared
                return;
            }

            DateTime selectedDate = Convert.ToDateTime(dateDE.EditValue);
            await LoadTopUpLogsByDateAsync(selectedDate);
        }

        private async Task LoadTopUpLogsByDateAsync(DateTime date)
        {
            try
            {
                var logs = await _logRepo.LoadTopUpLogsByDateAsync(date);

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
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load filtered top-up logs: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void findTE_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            gvTopUp.ApplyFindFilter(e.NewValue as string);
        }

        private void printBTN_Click(object sender, EventArgs e)
        {
            if (dateDE.EditValue == null)
            {
                MessageBox.Show("Please select a date before printing the report.",
                    "No Date Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime selectedDate = Convert.ToDateTime(dateDE.EditValue);

            Reports.TopUpHistoryXtraReport report = new Reports.TopUpHistoryXtraReport();

            using (var connection = new SqlConnection(SQLQuery.connectionString))
            {
                string query = TopUpLogQuery.GetTopUpLogsByDate;

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Date", selectedDate.Date);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        report.DataSource = dt;

                        report.xrLabel3.Text = selectedDate.ToString("MMMM dd, yyyy");
                        report.CreateDocument();
                        ReportPrintTool tool = new ReportPrintTool(report);
                        tool.ShowPreviewDialog();
                    }
                }
            }
        }
    }
}
