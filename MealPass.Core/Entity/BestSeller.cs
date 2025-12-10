using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPass.Core.Entity
{
    public class BestSeller
    {
        public string ProductName { get; set; }
        public int TotalQuantitySold { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
