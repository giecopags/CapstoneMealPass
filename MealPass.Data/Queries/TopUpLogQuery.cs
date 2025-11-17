using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPass.Data.Queries
{
    public static class TopUpLogQuery
    {
        public const string InsertTopUpLog = @"
            INSERT INTO TopUpLogs (
                StudentID,
                Username,
                Amount,
                PreviousBalance,
                NewBalance,
                TopUpDate,
                Status
            )
            VALUES (
                @StudentID,
                @Username,
                @Amount,
                @PreviousBalance,
                @NewBalance,
                @TopUpDate,
                @Status
            );
        ";

        public const string LoadTopUpLogs = @"
            SELECT 
                TopUpID,
                StudentID,
                Username,
                FORMAT(TopUpDate, 'dd/MM/yy hh:mm tt') AS TopUpDate,
                Amount,
                Status
            FROM TopUpLogs
            ORDER BY TopUpID DESC;";

        public const string GetTopUpLogsByDate = @"
            SELECT TopUpID, StudentID, Username, Amount, PreviousBalance, NewBalance, TopUpDate, Status
            FROM TopUpLogs
            WHERE CAST(TopUpDate AS DATE) = @Date
            ORDER BY TopUpDate DESC";
    }
}
