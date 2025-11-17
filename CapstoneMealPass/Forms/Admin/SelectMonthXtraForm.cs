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
    public partial class SelectMonthXtraForm : DevExpress.XtraEditors.XtraForm
    {
        public SelectMonthXtraForm()
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

            DateTime monthStart = new DateTime(selectedDate.Year, selectedDate.Month, 1);
            DateTime monthEnd = monthStart.AddMonths(1).AddDays(-1);

            Reports.MonthlySalesXtraReport report = new Reports.MonthlySalesXtraReport();

            using (var connection = new SqlConnection(SQLQuery.connectionString))
            {
                string query = SaleQuery.MonthlySalesReport;

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MonthStart", monthStart.Date);
                    command.Parameters.AddWithValue("@MonthEnd", monthEnd.Date);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        report.DataSource = dt;

                        report.xrLabel3.Text = $"{monthStart:MMMM yyyy}";

                        report.CreateDocument();
                        ReportPrintTool tool = new ReportPrintTool(report);
                        tool.ShowPreviewDialog();
                    }
        
                }
            }
        }

    }
}
