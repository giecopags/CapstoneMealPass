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
    }
}