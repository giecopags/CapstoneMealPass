using MealPass.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPass.Core.Interface
{
    public interface ISBalanceRepository
    {
        Task<SBalance> GetSBalanceByStaffIDAsync(string staffId);
        Task InsertSBalanceAsync(string staffId, decimal initialStaffCredit);
        Task AddSBalanceAsync(SBalance sBalance);
        Task UpdateStaffCreditAsync(string staffId, decimal newStaffCredit);
        Task UpdateStaffBalanceAsync(string staffId, decimal newStaffBalance);
        Task<bool> IsAccountLockedAsync(string staffId);
    }
}
