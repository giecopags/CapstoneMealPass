using System.ComponentModel.DataAnnotations;

namespace MealPass.Shared.Models
{
    public class TransactionDetails
    {
        [Key]
        public int TransactionDetailID { get; set; }
        public string ReferenceID { get; set; }
        public int ProductID { get; set; }

        public string ProductName { get; set; }
        public int QuantitySold { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Subtotal { get; set; }

        public Products Product { get; set; }
    }
}
