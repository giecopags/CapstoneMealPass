using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapstoneMealPass.Helpers;
using Dapper;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using MealPass.Core.GlobalSql;
using MealPass.Data.Queries;
using System.Data.SqlClient;

namespace CapstoneMealPass.Forms.Admin
{
    public partial class EmployeesUserControl : DevExpress.XtraEditors.XtraUserControl
    {
        public EmployeesUserControl()
        {
            InitializeComponent();
            FilterAllEmployees();

        }

        private void addemployeeBTN_Click(object sender, EventArgs e)
        {
            FormHelper.DisplayForm(new Admin.AddEmployeeRibbonForm());

        }

        private DataTable FilterAllEmployees()
        {
            using (SqlConnection connection = new SqlConnection(SQLQuery.connectionString))
            {
                connection.Open();
                string query = EmployeeQuery.FilterAllEmployees;
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        gcEmployees.DataSource = dataTable;
                        return dataTable;
                    }
                }
            }
        }

        private void findTE_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            gvEmployees.ApplyFindFilter(e.NewValue as string);
        }

        private void gvEmployees_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            string selectedUsername = Convert.ToString(gvEmployees.GetRowCellValue(e.RowHandle, "Username"));

            if (!string.IsNullOrEmpty(selectedUsername))
            {
                using (Forms.Admin.EditEmployeeRibbonForm editForm = new Admin.EditEmployeeRibbonForm(selectedUsername))
                {
                    editForm.ShowDialog();
                }

                FilterAllEmployees();
            }
        }

        private void gvEmployees_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;

            if (e.Column.FieldName == "IsLocked" && e.RowHandle >= 0)
            {
                var isLocked = view.GetRowCellValue(e.RowHandle, "IsLocked");
                if (isLocked == null)
                    return;

                string account = isLocked.ToString();

                if (account == "Locked")
                {
                    e.Appearance.ForeColor = Color.Red;
                }
                else
                {
                    e.Appearance.ForeColor = Color.Black;
                }

            }
        }
    }
}

