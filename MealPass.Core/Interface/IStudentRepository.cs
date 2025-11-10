using MealPass.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPass.Core.Interface
{
    public interface IStudentRepository
    {
        Task<Student> GetStudentByRFIDAsync(string rfid);
    }
}
