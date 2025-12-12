using Dapper;
using MealPass.Core.Entity;
using MealPass.Core.Interface;
using MealPass.Data.Queries;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPass.Data.Repositories
{
    public class TopUpLogRepository : ITopUpLogRepository
    {
        private readonly string _connectionString;

        public TopUpLogRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task InsertTopUpLogAsync(TopUpLog log)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                await conn.OpenAsync();

                using (SqlCommand cmd = new SqlCommand(TopUpLogQuery.InsertTopUpLog, conn))
                {
                    cmd.Parameters.AddWithValue("@StudentID", log.StudentID);
                    cmd.Parameters.AddWithValue("@Username", log.Username);
                    cmd.Parameters.AddWithValue("@Amount", log.Amount);
                    cmd.Parameters.AddWithValue("@PreviousBalance", log.PreviousBalance);
                    cmd.Parameters.AddWithValue("@NewBalance", log.NewBalance);
                    cmd.Parameters.AddWithValue("@TopUpDate", log.TopUpDate);
                    cmd.Parameters.AddWithValue("@Status", log.Status);

                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task<DataTable> LoadTopUpLogsAsync()
        {
            var dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(TopUpLogQuery.LoadTopUpLogs, conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                await conn.OpenAsync();
                adapter.Fill(dt);
            }

            return dt;
        }

        public async Task<List<TopUpLog>> LoadTopUpLogsByDateAsync(DateTime date)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                var result = await conn.QueryAsync<TopUpLog>(
                    TopUpLogQuery.GetTopUpLogsByDate,
                    new { Date = date.Date });

                return result.ToList();
            }
        }

        public async Task<List<TopUpLog>> LoadTopUpLogsByDateRangeAsync(DateTime from, DateTime to)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                var result = await conn.QueryAsync<TopUpLog>(
                    TopUpLogQuery.GetTopUpLogsByDateRange,
                    new { FromDate = from, ToDate = to });

                return result.ToList();
            }
        }
    }
}
