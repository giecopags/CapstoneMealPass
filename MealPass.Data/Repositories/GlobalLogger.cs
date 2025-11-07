using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MealPass.Core.GlobalSql;

namespace MealPass.Data.Repositories
{
    public class GlobalLogger
    {
        public static async Task EmployeeLoginLogAsync(string username, bool isSuccess)
        {
            string connectionString = SQLQuery.connectionString;
            string status = isSuccess ? "Success" : "Failed";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();

                string insertQuery = @"
                    INSERT INTO dbo.EmployeeLogs (Username, DateTime, Activity, Authentication)
                    VALUES (@Username, @DateTime, @Activity, @Authentication)";

                using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@DateTime", DateTime.Now);
                    cmd.Parameters.AddWithValue("@Activity", "Login attempt");
                    cmd.Parameters.AddWithValue("@Authentication", status);

                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public static async Task EmployeeLogAsync(string activity, string username)
        {
            string connectionString = SQLQuery.connectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();

                string insertQuery = @"
                    INSERT INTO dbo.EmployeeLogs (Username, DateTime, Activity, Authentication)
                    VALUES (@Username, @DateTime, @Activity, NULL)";

                using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@DateTime", DateTime.Now);
                    cmd.Parameters.AddWithValue("@Activity", activity);

                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }
    }
}