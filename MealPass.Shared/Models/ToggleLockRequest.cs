using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPass.Shared.Models
{
    public class ToggleLockRequest
    {
        public string StudentID { get; set; }
        public int IsLocked { get; set; }
    }
}
