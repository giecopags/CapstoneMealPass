using CapstoneMealPass.Helpers;
using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapstoneMealPass.Forms.Staff
{
    public partial class StaffMainRibbonForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public StaffMainRibbonForm()
        {
            InitializeComponent();
            this.KeyPreview = true;
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

        private async void posACE_Click(object sender, EventArgs e)
        {
            await FormHelper.LoadUserControlAsync(mainSPanel, () => new Staff.POSUserControl());
        }

        private async void salesreportACE_Click(object sender, EventArgs e)
        {
            await FormHelper.LoadUserControlAsync(mainSPanel, () => new Admin.SalesUserControl());
        }

        private async void purchasehistoryACE_Click(object sender, EventArgs e)
        {
            await FormHelper.LoadUserControlAsync(mainSPanel, () => new Admin.PurchaseHistoryUserControl());
        }

        private async void topuphistoryACE_Click(object sender, EventArgs e)
        {
            await FormHelper.LoadUserControlAsync(mainSPanel, () => new Admin.TopUpHistoryUserControl());
        }

        private void topupACE_Click(object sender, EventArgs e)
        {
            FormHelper.DisplayForm(new Staff.TopUpXtraForm());
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

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // First, delegate to POSUserControl if it's loaded
            if (mainSPanel.Controls.OfType<Staff.POSUserControl>().FirstOrDefault() is Staff.POSUserControl posUC)
            {
                if (posUC.HandleShortcut(keyData))
                    return true;
            }

            // Form-level shortcuts
            switch (keyData)
            {
                case Keys.F1:
                    // Open TopUp form
                    topupACE_Click(this, EventArgs.Empty);
                    return true;

                case Keys.F2:
                    // Load POS user control
                    posACE_Click(this, EventArgs.Empty);
                    return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
}