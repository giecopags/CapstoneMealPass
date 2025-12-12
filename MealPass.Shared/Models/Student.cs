using System.ComponentModel.DataAnnotations;

namespace MealPass.Shared.Models
{
    public class Student
    {
        public string StudentID { get; set; }

        public string Password { get; set; }

        public string RFID { get; set; }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }
    }
}
