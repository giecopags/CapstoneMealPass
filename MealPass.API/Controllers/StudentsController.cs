using Microsoft.AspNetCore.Mvc;
using MealPass.API.Data;
using MealPass.Shared.Models;

namespace MealPass.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly MealPassDBContext _context;
        public StudentsController(MealPassDBContext context)
        {
            _context = context;
        }

        // GET api/students/{studentID}
        [HttpGet("{studentID}")]
        public IActionResult GetStudent(string studentID)
        {
            var student = _context.Students
                .Where(s => s.StudentID == studentID)
                .Select(s => new {
                    s.StudentID,
                    s.FirstName,
                    s.Password // hashed password
                })
                .FirstOrDefault();

            if (student == null)
                return NotFound();

            return Ok(student);
        }
    }
}
