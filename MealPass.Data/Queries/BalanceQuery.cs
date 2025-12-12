using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPass.Data.Queries
{
    public static class BalanceQuery
    {
        public const string GetByStudentID = @"
            SELECT StudentID, StudentBalance
            FROM Balance
            WHERE StudentID = @StudentID";

        public const string UpdateBalance = @"
            UPDATE Balance
            SET StudentBalance = @StudentBalance
            WHERE StudentID = @StudentID";

        public const string InsertBalance = @"
            INSERT INTO Balance (StudentID, StudentBalance)
            VALUES (@StudentID, @StudentBalance)";

        public const string DeductBalance = @"
            UPDATE Balance
            SET StudentBalance = StudentBalance - @Amount
            WHERE StudentID = @StudentID";

        public const string CheckIfLocked = @"
            SELECT IsLocked 
            FROM Balance
            WHERE StudentID = @StudentID";
    }
}
