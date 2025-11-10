using MealPass.Core.Entity;
using MealPass.Core.Interface;
using MealPass.Data.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;

namespace MealPass.Data.Repositories
{
    public class BalanceRepository : IBalanceRepository
    {
        private readonly string _connectionString;

        public BalanceRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<Balance> GetBalanceByStudentIDAsync(string studentId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                return await connection.QueryFirstOrDefaultAsync<Balance>(BalanceQuery.GetByStudentID, new { StudentID = studentId });
            }
        }

        public async Task UpdateBalanceAsync(string studentId, decimal newBalance)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.ExecuteAsync(BalanceQuery.UpdateBalance, new
                {
                    StudentBalance = newBalance,
                    StudentID = studentId
                });
            }
        }

        public async Task InsertBalanceAsync(string studentId, decimal initialBalance)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                await connection.ExecuteAsync(
                    BalanceQuery.InsertBalance,
                    new { StudentID = studentId, StudentBalance = initialBalance });
            }
        }
        public async Task AddBalanceAsync(Balance balance)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.ExecuteAsync(
                    BalanceQuery.InsertBalance,
                    new
                    {
                        balance.StudentID,
                        balance.StudentBalance
                    }
                );
            }
        }
    }
}
