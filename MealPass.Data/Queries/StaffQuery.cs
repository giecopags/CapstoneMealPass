using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPass.Data.Queries
{
    public class StaffQuery
    {
        public const string GetByRFID = @"
            SELECT TOP 1 StaffID, RFID, FirstName, MiddleName, LastName, Email
            FROM Staff
            WHERE RFID = @RFID";
    }
}
