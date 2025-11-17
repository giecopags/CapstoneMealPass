using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPass.Core.Entity
{
    public class TopUpLog
    {
        public int TopUpID { get; set; }          // Auto-increment PK
        public string StudentID { get; set; }
        public string Username { get; set; }
        public decimal Amount { get; set; }
        public decimal PreviousBalance { get; set; }
        public decimal NewBalance { get; set; }
        public DateTime TopUpDate { get; set; }
        public string Status { get; set; }
    }
}
