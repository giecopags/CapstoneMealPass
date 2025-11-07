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

namespace CapstoneMealPass.Forms.Admin
{
    public partial class MainRibbonForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainRibbonForm()
        {
            InitializeComponent();
            datetimeLBL.Text = DateTime.Now.ToString("F");
            usernameLBL.Text = UserSession.Username;
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
            await FormHelper.LoadUserControlAsync(mainSPanel, () => new Staff.POSUserControl());
        }
    }
}