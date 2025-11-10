using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPass.Core.Entity
{
    public class Student
    {
        public string StudentID { get; set; }
        public string RFID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public string FullName => $"{FirstName} {MiddleName} {LastName}".Trim();
    }
}
