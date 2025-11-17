using Dapper;
using MealPass.Core.Entity;
using MealPass.Core.GlobalSql;
using MealPass.Core.Interface;
using MealPass.Data.Queries;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MealPass.Data.Repositories
{
    public class PurchaseHistoryRepository : IPurchaseHistoryRepository
    {
        private readonly string _connectionString;

        public PurchaseHistoryRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<List<PurchaseHistory>> GetAllPurchaseHistoryAsync()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var result = await connection.QueryAsync<PurchaseHistory>(
                    PurchaseHistoryQuery.GetAllPurchaseHistory);

                return result.ToList();
            }
        }

        public async Task<List<PurchaseHistory>> GetPurchaseHistoryByDateAsync(DateTime date)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var result = await connection.QueryAsync<PurchaseHistory>(
                    PurchaseHistoryQuery.GetPurchaseHistoryByDate,
                    new { Date = date.Date });

                return result.ToList();
            }
        }

        public async Task<List<PurchasedItem>> GetPurchasedItemsByReferenceIDAsync(string referenceID)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var result = await connection.QueryAsync<PurchasedItem>(
                    PurchaseHistoryQuery.GetPurchasedItemsByReferenceID,
                    new { ReferenceID = referenceID }
                );

                return result.ToList();
            }
        }
    }
}
