using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPass.Data.Queries
{
    public static class StudentQuery
    {
        public const string GetByRFID = @"
            SELECT TOP 1 StudentID, RFID, FirstName, MiddleName, LastName, Email
            FROM Students
            WHERE RFID = @RFID";
    }
}
