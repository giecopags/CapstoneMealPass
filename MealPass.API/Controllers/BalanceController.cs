using System.Text.Json;
using MealPass.API.Data;
using MealPass.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace MealPass.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BalanceController : ControllerBase
    {
        private readonly MealPassDBContext _context;
        public BalanceController(MealPassDBContext context)
        {
            _context = context;
        }

        [HttpGet("{studentID}")]
        public IActionResult GetBalance(string studentID)
        {
            var balance = _context.Balance
                .FirstOrDefault(b => b.StudentID == studentID);

            if (balance == null)
                return NotFound();

            return Ok(balance);
        }

        [HttpPost("togglelock/{studentID}")]
        public IActionResult ToggleAccountLock(string studentID, [FromBody] ToggleLockRequest payload)
        {
            var balance = _context.Balance.FirstOrDefault(b => b.StudentID == studentID);
            if (balance == null) return NotFound();

            balance.IsLocked = payload.IsLocked;
            _context.SaveChanges();

            return Ok(new { IsLocked = balance.IsLocked });
        }
    }
}
