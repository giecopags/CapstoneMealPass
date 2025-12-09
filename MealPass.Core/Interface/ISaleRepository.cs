using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MealPass.Core.Entity;

namespace MealPass.Core.Interface
{
    public interface ISaleRepository
    {
        Task<List<SalesSummary>> GetAllSalesSummaryAsync();
        Task<List<SalesSummary>> GetSalesSummaryByDateAsync(DateTime date);
        Task<List<SalesSummary>> GetSalesSummaryByDateTimeRangeAsync(DateTime from, DateTime to);
    }
}
