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
using MealPass.Data.Queries;

namespace CapstoneMealPass.Forms.Admin
{
    public partial class SelectWeekXtraForm : DevExpress.XtraEditors.XtraForm
    {
        public SelectWeekXtraForm()
        {
            InitializeComponent();
        }

        private void printBTN_Click(object sender, EventArgs e)
        {
            if (dateDE.EditValue == null)
            {
                MessageBox.Show("Please select a date first.", "No Date Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime selectedDate = Convert.ToDateTime(dateDE.EditValue);

            int diff = DayOfWeek.Monday - selectedDate.DayOfWeek;
            DateTime weekStart = selectedDate.AddDays(diff);
            DateTime weekEnd = weekStart.AddDays(6);

            Reports.WeeklySalesXtraReport report = new Reports.WeeklySalesXtraReport();

            using (var connection = new SqlConnection(SQLQuery.connectionString))
            {
                string query = SaleQuery.WeeklySalesReport; 

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@WeekStart", weekStart.Date);
                    command.Parameters.AddWithValue("@WeekEnd", weekEnd.Date);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        report.DataSource = dt;

                        report.xrLabel3.Text = $"{weekStart:MMM dd, yyyy} - {weekEnd:MMM dd, yyyy}";

                        report.CreateDocument();
                        ReportPrintTool tool = new ReportPrintTool(report);
                        tool.ShowPreviewDialog();
                    }
                }
            }
        }
    }
}
