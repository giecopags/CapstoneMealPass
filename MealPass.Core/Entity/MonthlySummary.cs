using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPass.Core.Entity
{
    public class MonthlySummary
    {
        public string Month { get; set; }      
        public decimal TotalSale { get; set; }
        public decimal TotalTopUp { get; set; }
    }
}
