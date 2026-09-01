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
    public class StaffRepository : IStaffRepository
    {
        private readonly string _connectionString;

        public StaffRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<Staff> GetStaffByRFIDAsync(string rfid)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                return await connection.QueryFirstOrDefaultAsync<Staff>(StaffQuery.GetByRFID, new { RFID = rfid });
            }
        }
    }
}
