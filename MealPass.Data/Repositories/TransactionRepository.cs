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

    public class TransactionRepository : ITransactionRepository
    {
        private readonly string _connectionString;

        public TransactionRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task InsertTransactionAsync(Transaction transaction)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.ExecuteAsync(TransactionQuery.InsertTransaction, new
                {
                    transaction.ReferenceID,
                    transaction.SaleDate,
                    transaction.StudentID,
                    transaction.Username,
                    transaction.TotalAmount,
                    transaction.PaymentMethod,
                    transaction.Remarks
                });
            }
        }

        public async Task InsertTransactionDetailAsync(TransactionDetail detail)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.ExecuteAsync(
                    TransactionQuery.InsertTransactionDetail,
                    detail
                );
            }
        }
    }
}
