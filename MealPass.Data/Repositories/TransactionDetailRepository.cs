using MealPass.Core.Entity;
using MealPass.Data.Queries;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MealPass.Core.Interface;
using Dapper;

namespace MealPass.Data.Repositories
{
    public class TransactionDetailRepository : ITransactionDetailRepository
    {
        private readonly string _connectionString;
        public TransactionDetailRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task InsertTransactionDetailAsync(TransactionDetail detail)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.ExecuteAsync(TransactionQuery.InsertTransactionDetail, new
                {
                    detail.TransactionDetailID,
                    detail.ReferenceID,
                    detail.ProductID,
                    detail.QuantitySold,
                    detail.UnitPrice,
                    detail.Subtotal
                });
            }
        }
    }
}
