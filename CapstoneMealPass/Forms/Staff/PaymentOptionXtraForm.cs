using CapstoneMealPass.Helpers;
using DevExpress.XtraEditors;
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
    public partial class PaymentOptionXtraForm : DevExpress.XtraEditors.XtraForm
    {
        public PaymentOptionXtraForm()
        {
            InitializeComponent();
        }

        private void mealpassBTN_Click(object sender, EventArgs e)
        {
            FormHelper.DisplayForm(new Staff.ScanRFIDXtraForm());
        }

        private void cashBTN_Click(object sender, EventArgs e)
        {
            FormHelper.DisplayForm(new Staff.CashOptionXtraForm());
        }

        private void topupBTN_Click(object sender, EventArgs e)
        {
            FormHelper.DisplayForm(new Staff.TopUpXtraForm());
        }
    }
}