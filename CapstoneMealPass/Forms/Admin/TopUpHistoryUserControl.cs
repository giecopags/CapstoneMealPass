using DevExpress.XtraEditors;
using MealPass.Core.Entity;
using MealPass.Core.GlobalSql;
using MealPass.Core.Interface;
using MealPass.Data.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
