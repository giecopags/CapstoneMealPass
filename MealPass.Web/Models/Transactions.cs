using System.ComponentModel.DataAnnotations;

namespace MealPass.Web.Models
{
    public class Transactions
    {
        [Key]
        public string ReferenceID { get; set; }
        public DateTime SaleDate { get; set; }
        public string Username { get; set; }
        public string StudentID { get; set; }
        public decimal TotalAmount { get; set; }
        public bool PaymentMethod { get; set; }
        public string Remarks { get; set; }
    }
}
