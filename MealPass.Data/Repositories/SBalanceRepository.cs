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
    public class SBalanceRepository : ISBalanceRepository
    {
        private readonly string _connectionString;

        public SBalanceRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<SBalance> GetSBalanceByStaffIDAsync(string staffId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                return await connection.QueryFirstOrDefaultAsync<SBalance>(SBalanceQuery.GetByStaffID, new { StaffID = staffId });
            }
        }

        // initialStaffCredit seeds StaffCredit; StaffBalance and IsLocked start at 0.
        // Adjust defaults here if new staff records should start differently.
        public async Task InsertSBalanceAsync(string staffId, decimal initialStaffCredit)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                await connection.ExecuteAsync(
                    SBalanceQuery.InsertSBalance,
                    new { StaffID = staffId, StaffBalance = 0m, IsLocked = 0, StaffCredit = initialStaffCredit });
            }
        }

        public async Task AddSBalanceAsync(SBalance sBalance)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.ExecuteAsync(
                    SBalanceQuery.InsertSBalance,
                    new
                    {
                        sBalance.StaffID,
                        sBalance.StaffBalance,
                        sBalance.IsLocked,
                        sBalance.StaffCredit
                    }
                );
            }
        }

        public async Task UpdateStaffCreditAsync(string staffId, decimal newStaffCredit)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.ExecuteAsync(SBalanceQuery.UpdateStaffCredit, new
                {
                    StaffCredit = newStaffCredit,
                    StaffID = staffId
                });
            }
        }

        public async Task UpdateStaffBalanceAsync(string staffId, decimal newStaffBalance)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.ExecuteAsync(SBalanceQuery.UpdateStaffBalance, new
                {
                    StaffBalance = newStaffBalance,
                    StaffID = staffId
                });
            }
        }

        public async Task<bool> IsAccountLockedAsync(string staffId)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                var result = await conn.ExecuteScalarAsync<int>(
                    SBalanceQuery.CheckIfLocked,
                    new { StaffID = staffId }
                );
                return result == 1;
            }
        }
    }
}
