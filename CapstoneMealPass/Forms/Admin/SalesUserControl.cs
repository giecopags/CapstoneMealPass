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
                    x.ProductID,
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
                    x.ProductID,
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

        private void printBTN_Click(object sender, EventArgs e)
        {
            if (dateDE.EditValue == null)
            {
                MessageBox.Show("Please select a date before printing the daily sales report.",
                    "No Date Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime selectedDate = Convert.ToDateTime(dateDE.EditValue);

            Reports.DailySalesXtraReport report = new Reports.DailySalesXtraReport();

            using (var connection = new SqlConnection(SQLQuery.connectionString))
            {
                string query = SaleQuery.GetSalesSummaryByDate;
          
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

