using System.ComponentModel.DataAnnotations;

namespace MealPass.Web.Models
{
    public class TopUpLogs
    {
        [Key]
        public int TopUpID { get; set; }

        public string StudentID { get; set; }

        public string Username { get; set; }
        public decimal Amount { get; set; }
        public decimal PreviousBalance { get; set; }
        public decimal NewBalance { get; set; }

        public DateTime TopUpDate { get; set; }
        public string Status { get; set; }
    }
}
