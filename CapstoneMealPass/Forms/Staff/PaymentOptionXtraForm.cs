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
using MealPass.Core.Entity;

namespace CapstoneMealPass.Forms.Staff
{
    public partial class PaymentOptionXtraForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly TransactionData _transaction;
        private readonly POSUserControl _posControl;
        public PaymentOptionXtraForm(TransactionData transaction, POSUserControl posControl)
        {
            InitializeComponent();
            _transaction = transaction;
            _posControl = posControl;
        }

        private void mealpassBTN_Click(object sender, EventArgs e)
        {
            var scanForm = new Staff.ScanRFIDXtraForm(_transaction,this,_posControl);
            FormHelper.DisplayForm(scanForm);
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