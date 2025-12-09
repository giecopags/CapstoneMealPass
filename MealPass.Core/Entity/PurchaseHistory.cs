using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPass.Core.Entity
{
    public class PurchaseHistory
    {
        public string ReferenceID { get; set; }
        public string Username { get; set; }
        public string StudentID { get; set; }
        public DateTime SaleDate { get; set; }
        public decimal TotalAmount { get; set; }
        public int PaymentMethod { get; set; }
        public string Remarks { get; set; }
    }
}
