using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPass.Core.Entity
{
    public class TransactionData
    {
        public DataTable CartItems { get; set; }
        public decimal GrandTotal { get; set; }
        public DateTime TransactionDateTime { get; set; }
        public string Username { get; set; } // Cashier username
    }
}
