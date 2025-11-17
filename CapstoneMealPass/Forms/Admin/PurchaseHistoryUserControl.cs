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
            await LoadPurchaseHistoryAsync();
        }

        private async Task LoadPurchaseHistoryAsync()
        {
            try
            {
                var purchases = await _purchaseRepo.GetAllPurchaseHistoryAsync();

                // Format values for display
                var formatted = purchases.Select(x => new
                {
                    x.ReferenceID,
                    x.Username,
                    x.StudentID,
                    SaleDate = x.SaleDate.ToString("dd/MM/yy hh:mm tt"),
                    x.TotalAmount,
                    PaymentMethod = x.PaymentMethod == 1 ? "Cash" : "MealPass"
                }).ToList();

                purchasehistoryGC.DataSource = formatted;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load purchase history: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void dateDE_EditValueChanged(object sender, EventArgs e)
        {
            if (dateDE.EditValue == null)
            {
                await LoadPurchaseHistoryAsync();
                return;
            }

            DateTime selectedDate = Convert.ToDateTime(dateDE.EditValue);
            await LoadPurchaseHistoryByDateAsync(selectedDate);
        }

        private async Task LoadPurchaseHistoryByDateAsync(DateTime date)
        {
            try
            {
                var purchases = await _purchaseRepo.GetPurchaseHistoryByDateAsync(date);

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
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load filtered purchase history: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
    }
}
