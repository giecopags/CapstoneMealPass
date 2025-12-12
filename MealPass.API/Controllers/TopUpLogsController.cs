using Microsoft.AspNetCore.Mvc;
using MealPass.API.Data;
using MealPass.Shared.Models;

namespace MealPass.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TopUpLogsController : ControllerBase
    {
        private readonly MealPassDBContext _context;
        public TopUpLogsController(MealPassDBContext context)
        {
            _context = context;
        }

        [HttpGet("{studentID}")]
        public IActionResult GetLogs(string studentID)
        {
            var logs = _context.TopUpLogs
                .Where(t => t.StudentID == studentID)
                .OrderByDescending(t => t.TopUpDate)
                .ToList();

            return Ok(logs);
        }
    }
}
