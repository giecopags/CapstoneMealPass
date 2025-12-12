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
            var cashForm = new Staff.CashOptionXtraForm(_transaction, this, _posControl);
            FormHelper.DisplayForm(cashForm);
        }

        private void topupBTN_Click(object sender, EventArgs e)
        {
            FormHelper.DisplayForm(new Staff.TopUpXtraForm());
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // ESC → Close form
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true; // mark as handled
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}