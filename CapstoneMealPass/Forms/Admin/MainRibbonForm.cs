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
using CapstoneMealPass.Helpers;
using DevExpress.XtraBars;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Wizards.Presenters;
using MealPass.Core.GlobalSql;
using MealPass.Data.Queries;

namespace CapstoneMealPass.Forms.Admin
{
    public partial class MainRibbonForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private Staff.POSUserControl posUserControlInstance;
        public MainRibbonForm()
        {
            InitializeComponent();
            datetimeLBL.Text = DateTime.Now.ToString("F");
            usernameLBL.Text = UserSession.Username;

            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            datetimeLBL.Text = DateTime.Now.ToString("F");
        }


        private async void employeelistACE_Click(object sender, EventArgs e)
        {
            await FormHelper.LoadUserControlAsync(mainSPanel, () => new Admin.EmployeesUserControl());
        }

        private async void productsACE_Click(object sender, EventArgs e)
        {
            await FormHelper.LoadUserControlAsync(mainSPanel, () => new Admin.ProductsUserControl());
        }

        private async void salesreportACE_Click(object sender, EventArgs e)
        {
            await FormHelper.LoadUserControlAsync(mainSPanel, () => new Admin.SalesUserControl());
        }

        private async void employeelogsACE_Click(object sender, EventArgs e)
        {
            await FormHelper.LoadUserControlAsync(mainSPanel, () => new Admin.EmployeeLogsUserControl());
        }

        private async void topuphistoryACE_Click(object sender, EventArgs e)
        {
            await FormHelper.LoadUserControlAsync(mainSPanel, () => new Admin.TopUpHistoryUserControl());
        }

        private async void purchasehistoryACE_Click(object sender, EventArgs e)
        {
            await FormHelper.LoadUserControlAsync(mainSPanel, () => new Admin.PurchaseHistoryUserControl());
        }

        private async void posACE_Click(object sender, EventArgs e)
        {
            posUserControlInstance = new Staff.POSUserControl();
            await FormHelper.LoadUserControlAsync(mainSPanel, () => posUserControlInstance);
        }

        private void topupACE_Click(object sender, EventArgs e)
        {
            FormHelper.DisplayForm(new Staff.TopUpXtraForm());
        }

        private async void salesreportACE_Click_2(object sender, EventArgs e)
        {
            await FormHelper.LoadUserControlAsync(mainSPanel, () => new Admin.SalesUserControl());
        }

        private void logout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                UserSession.Username = null;

                this.Hide();

                var loginForm = new LoginForm();
                loginForm.Show();
            }
        }

        private async void dashboardACE_Click(object sender, EventArgs e)
        {
            await FormHelper.LoadUserControlAsync(mainSPanel, () => new Admin.DashboarddUserControl());
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Delegate shortcut handling to the POS User Control
            if (posUserControlInstance != null)
            {
                if (posUserControlInstance.HandleShortcut(keyData))
                    return true;
            }

            // Shortcut for TopUp (F1)
            if (keyData == Keys.F1)
            {
                topupACE_Click(this, EventArgs.Empty);
                return true;
            }

            // Shortcut for POS (F2)
            if (keyData == Keys.F2)
            {
                posACE_Click(this, EventArgs.Empty);
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

       
    }
}
