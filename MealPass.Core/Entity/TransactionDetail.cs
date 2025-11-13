using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPass.Core.Entity
{
    public class TransactionDetail
    {
        public int TransactionDetailID { get; set; }  // Auto-increment PK
        public string ReferenceID { get; set; }        // FK → Transactions.ReferenceID
        public int ProductID { get; set; }             // FK → Products.ProductID
        public int QuantitySold { get; set; }          // Quantity sold for that product
        public decimal UnitPrice { get; set; }         // Price per unit at time of sale
        public decimal Subtotal { get; set; }          // UnitPrice * QuantitySold
    }
}
