using DevExpress.XtraEditors;
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
using MealPass.Core.GlobalSql;
using MealPass.Core.Interface;

namespace CapstoneMealPass.Forms.Admin
{
    public partial class PurchaseHistoryUserControl : DevExpress.XtraEditors.XtraUserControl
    {
        private readonly IPurchaseHistoryRepository _purchaseRepo;

        public PurchaseHistoryUserControl()
        {
            InitializeComponent();

            string connectionString = SQLQuery.connectionString;
            _purchaseRepo = new PurchaseHistoryRepository(connectionString);

            this.Load += PurchaseHistoryUserControl_Load;
        }

        private async void PurchaseHistoryUserControl_Load(object sender, EventArgs e)
        {
            await LoadPurchaseHistoryTodayAsync();
        }

        public async Task LoadPurchaseHistoryTodayAsync()
        {
            DateTime today = DateTime.Today;

            var purchases = await _purchaseRepo.GetPurchaseHistoryByDateAsync(today);

            var formatted = purchases.Select(x => new
            {
                x.ReferenceID,
                x.Username,
                x.StudentID,
                SaleDate = x.SaleDate.ToString("dd/MM/yy hh:mm tt"),
                TotalAmount = x.TotalAmount.ToString("N2"),
                PaymentMethod = x.PaymentMethod == 1 ? "Cash" : "MealPass"
            }).ToList();

            purchasehistoryGC.DataSource = formatted;
        }

        private async Task LoadPurchaseHistoryByRangeAsync(DateTime from, DateTime to)
        {
            DateTime toInclusive = to.Date.AddDays(1).AddTicks(-1);

            var purchases = await _purchaseRepo.GetPurchaseHistoryByDateRangeAsync(from, toInclusive);

            purchasehistoryGC.DataSource = purchases.Select(x => new
            {
                x.ReferenceID,
                x.Username,
                x.StudentID,
                SaleDate = x.SaleDate.ToString("dd/MM/yy hh:mm tt"),
                TotalAmount = x.TotalAmount.ToString("N2"),
                PaymentMethod = x.PaymentMethod == 1 ? "Cash" : "MealPass"
            }).ToList();
        }

        private async void purchasehistoryGV_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.RowHandle < 0)
                return;

            var referenceID = purchasehistoryGV.GetRowCellValue(e.RowHandle, "ReferenceID")?.ToString();

            var totalAmountObj = purchasehistoryGV.GetRowCellValue(e.RowHandle, "TotalAmount");

            decimal totalAmount = 0;
            if (totalAmountObj != null)
                decimal.TryParse(totalAmountObj.ToString(), out totalAmount);

            grandtotalLBL.Text = totalAmount.ToString("N2");

            if (!string.IsNullOrEmpty(referenceID))
                await LoadPurchasedItemsAsync(referenceID);
        }

        private async Task LoadPurchasedItemsAsync(string referenceID)
        {
            try
            {
                var items = await _purchaseRepo.GetPurchasedItemsByReferenceIDAsync(referenceID);

                productpurchasesGC.DataSource = items;
                productpurchasesGV.Columns["UnitPrice"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                productpurchasesGV.Columns["UnitPrice"].DisplayFormat.FormatString = "N2";

                productpurchasesGV.Columns["Subtotal"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                productpurchasesGV.Columns["Subtotal"].DisplayFormat.FormatString = "N2";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load purchased items: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void findTE_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            purchasehistoryGV.ApplyFindFilter(e.NewValue as string);
        }

        private async void filterBTN_Click(object sender, EventArgs e)
        {
            if (fromDateDE.EditValue == null || toDateDE.EditValue == null)
            {
                MessageBox.Show("Please select both From and To dates.", "Invalid Date Range",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime from;
            DateTime to;

            bool isFromValid = DateTime.TryParse(fromDateDE.EditValue.ToString(), out from);
            bool isToValid = DateTime.TryParse(toDateDE.EditValue.ToString(), out to);

            if (!isFromValid || !isToValid)
            {
                MessageBox.Show("Selected dates are invalid. Please select valid dates.", "Invalid Date Range",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (from > to)
            {
                MessageBox.Show("The 'From' date cannot be after the 'To' date.", "Invalid Date Range",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            await LoadPurchaseHistoryByRangeAsync(from, to);
        }
    }
}
