using MealPass.Core.Entity;
using MealPass.Core.Interface;
using MealPass.Data.Queries;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace MealPass.Data.Repositories
{
    public class DashboardRepository : IDashboardRepository
    {
        private readonly string _connectionString;

        public DashboardRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public async Task<List<MonthlySummary>> GetMonthlySummaryAsync()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var sales = await connection.QueryAsync<(string Month, decimal TotalSale)>(
                    DashboardQuery.GetMonthlySales);

                var topups = await connection.QueryAsync<(string Month, decimal TotalTopUp)>(
                    DashboardQuery.GetMonthlyTopUps);

                var summary =
                    from s in sales
                    join t in topups on s.Month equals t.Month into temp
                    from tt in temp.DefaultIfEmpty()
                    select new MonthlySummary
                    {
                        Month = s.Month,
                        TotalSale = s.TotalSale,
                        TotalTopUp = tt.TotalTopUp
                    };

                return summary.ToList();
            }
        }

        public async Task<List<BestSeller>> GetTopBestSellersThisMonthAsync()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var data = await connection.QueryAsync<BestSeller>(
                    DashboardQuery.GetTopBestSellersThisMonth);

                return data.ToList();
            }
        }

        public async Task<List<BestSeller>> GetTopBestSellersByMonthAsync(int month, int year)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var data = await connection.QueryAsync<BestSeller>(
                    DashboardQuery.GetTopBestSellersByMonth,
                    new { Month = month, Year = year }
                );

                return data.ToList();
            }
        }

        public async Task<int> GetLowStockCountAsync()
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                return await conn.ExecuteScalarAsync<int>(DashboardQuery.GetLowStockCount);
            }
        }

        public async Task<int> GetOutOfStockCountAsync()
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                return await conn.ExecuteScalarAsync<int>(DashboardQuery.GetOutOfStockCount);
            }
        }
    }
}
