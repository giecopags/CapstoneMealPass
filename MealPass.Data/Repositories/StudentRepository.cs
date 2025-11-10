using MealPass.Core.Entity;
using MealPass.Core.Interface;
using MealPass.Data.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MealPass.Core.GlobalSql;
using Dapper;
using System.Data.SqlClient;

namespace MealPass.Data.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly string _connectionString;
        public StudentRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<Student> GetStudentByRFIDAsync(string rfid)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                return await connection.QueryFirstOrDefaultAsync<Student>(StudentQuery.GetByRFID, new { RFID = rfid });
            }
        }
    }
}
