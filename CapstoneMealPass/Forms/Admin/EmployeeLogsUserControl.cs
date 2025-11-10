using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using MealPass.Core.GlobalSql;
using Microsoft.Data.SqlClient;

namespace CapstoneMealPass.Forms.Admin
{
    public partial class EmployeeLogsUserControl : DevExpress.XtraEditors.XtraUserControl
    {
        public EmployeeLogsUserControl()
        {
            InitializeComponent();
        }

        private async Task LoadLogsIntoGridAsync()
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
                    ORDER BY el.LogID DESC";

                await connection.OpenAsync();

                using (var cmd = new SqlCommand(query, connection))
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    var dt = new DataTable();
                    dt.Load(reader);
                    gcEmployeeLogs.DataSource = dt;
                }

                if (gcEmployeeLogs.MainView is GridView view)
                {
                    view.Columns["DateTime"].DisplayFormat.FormatType = FormatType.DateTime;
                    view.Columns["DateTime"].DisplayFormat.FormatString = "MM/dd/yyyy hh:mm tt";
                    view.BestFitColumns();
                }
            }
        }

        private async void gcEmployeeLogs_Load(object sender, EventArgs e)
        {
           await LoadLogsIntoGridAsync();
        }

        private void printBTN_Click(object sender, EventArgs e)
        {
            Reports.EmployeeLogsXtraReport reports = new Reports.EmployeeLogsXtraReport();

            using (var connection = new SqlConnection(SQLQuery.connectionString))
            {
                string query = @"SELECT    el.LogID, 
                                           el.Username,
	                                       el.DateTime, 
	                                       el.Activity,
                                           el.Authentication
                                    FROM dbo.EmployeeLogs el
                                    ORDER BY el.LogID DESC";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        reports.DataSource = dataTable;
                        DevExpress.XtraReports.UI.ReportPrintTool printTool = new DevExpress.XtraReports.UI.ReportPrintTool(reports);
                        printTool.ShowPreviewDialog();
                    }
                }
            }
        }
    }
}
