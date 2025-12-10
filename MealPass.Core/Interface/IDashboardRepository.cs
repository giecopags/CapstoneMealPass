using MealPass.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPass.Core.Interface
{
    public interface IDashboardRepository
    {
        Task<List<MonthlySummary>> GetMonthlySummaryAsync();
        Task<List<BestSeller>> GetTopBestSellersThisMonthAsync();
        Task<List<BestSeller>> GetTopBestSellersByMonthAsync(int month, int year);
    }
}
