using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MealPass.Shared.Models
{
    [Table("Products", Schema = "pro")]
    public class Products
    {
        [Key]
        public int ProductID { get; set; }
        public string ProductName { get; set; }

        public int CategoryID { get; set; }

        public int StockStatusID { get; set; }

        public int LowStockLevel { get; set; }
        public int Quantity { get; set; }

        public decimal Price { get; set; }

    }
}
