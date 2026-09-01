using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPass.Data.Queries
{
    public static class SBalanceQuery
    {
        public const string GetByStaffID = @"
            SELECT StaffID, StaffBalance, IsLocked, StaffCredit
            FROM SBalance
            WHERE StaffID = @StaffID";

        public const string InsertSBalance = @"
            INSERT INTO SBalance (StaffID, StaffBalance, IsLocked, StaffCredit)
            VALUES (@StaffID, @StaffBalance, @IsLocked, @StaffCredit)";

        public const string UpdateStaffCredit = @"
            UPDATE SBalance
            SET StaffCredit = @StaffCredit
            WHERE StaffID = @StaffID";

        public const string UpdateStaffBalance = @"
            UPDATE SBalance
            SET StaffBalance = @StaffBalance
            WHERE StaffID = @StaffID";

        public const string CheckIfLocked = @"
            SELECT CASE WHEN IsLocked = 1 THEN 1 ELSE 0 END
            FROM SBalance
            WHERE StaffID = @StaffID";
    }
}

