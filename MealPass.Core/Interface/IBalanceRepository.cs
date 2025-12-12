using MealPass.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPass.Core.Interface
{
    public interface IBalanceRepository
    {
        Task<Balance> GetBalanceByStudentIDAsync(string studentId);
        Task UpdateBalanceAsync(string studentId, decimal newBalance);
        Task InsertBalanceAsync(string studentId, decimal initialBalance);
        Task AddBalanceAsync(Balance balance);
        Task DeductBalanceAsync(string studentId, decimal amount);
        Task<bool> IsAccountLockedAsync(string studentId);
    }
}
