using Dapper;
using MealPass.Core.Interface;
using MealPass.Data.Queries;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MealPass.Core.Entity;

namespace MealPass.Data.Repositories
{
    public class SaleRepository : ISaleRepository
    {
        private readonly string _connectionString;

        public SaleRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<List<SalesSummary>> GetAllSalesSummaryAsync()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var result = await connection.QueryAsync<SalesSummary>(
                    SaleQuery.GetAllSalesSummary
                );

                return result.ToList();
            }
        }

        public async Task<List<SalesSummary>> GetSalesSummaryByDateAsync(DateTime date)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var result = await connection.QueryAsync<SalesSummary>(
                    SaleQuery.GetSalesSummaryByDate,
                    new { Date = date.Date }
                );

                return result.ToList();
            }
        }

        public async Task<List<SalesSummary>> GetSalesSummaryByDateTimeRangeAsync(DateTime from, DateTime to)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var result = await connection.QueryAsync<SalesSummary>(
                    SaleQuery.GetSalesSummaryByDateTimeRange,
                    new { FromDateTime = from, ToDateTime = to }
                );

                return result.ToList();
            }
        }

    }
}
