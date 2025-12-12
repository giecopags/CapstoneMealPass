using System.ComponentModel.DataAnnotations;

namespace MealPass.Web.Models
{
    public class Balance
    {
        [Key]
        public string StudentID { get; set; }

        public decimal StudentBalance { get; set; }

        public int IsLocked { get; set; }
    }
}
