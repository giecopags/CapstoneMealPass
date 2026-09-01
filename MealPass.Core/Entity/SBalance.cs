using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPass.Core.Entity
{
    public class SBalance
    {
        public string StaffID { get; set; }
        public decimal StaffBalance { get; set; }
        public int IsLocked { get; set; }
        public decimal StaffCredit { get; set; }
    }
}
