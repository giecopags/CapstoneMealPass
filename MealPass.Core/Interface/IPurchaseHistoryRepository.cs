using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MealPass.Core.Entity;

namespace MealPass.Core.Interface
{
    public interface IPurchaseHistoryRepository
    {
        Task<List<PurchaseHistory>> GetAllPurchaseHistoryAsync();

        Task<List<PurchaseHistory>> GetPurchaseHistoryByDateAsync(DateTime date);

        Task<List<PurchasedItem>> GetPurchasedItemsByReferenceIDAsync(string referenceID);
    }
}
