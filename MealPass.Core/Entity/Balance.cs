using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPass.Core.Entity
{
    public class Balance
    {
        public string StudentID { get; set; }
        public decimal StudentBalance { get; set; }
        public int IsLocked { get; set; }
    }
}
