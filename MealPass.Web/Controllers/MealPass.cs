using Microsoft.AspNetCore.Mvc;
using MealPass.Web.Models;
using System.Linq;
using BCrypt.Net;

namespace MealPass.Web.Controllers
{
    public class MealPass : Controller
    {
        private readonly MealPassDBContext _context;

        public MealPass(MealPassDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string studentID, string password)
        {
            if (string.IsNullOrEmpty(studentID) || string.IsNullOrEmpty(password))
            {
                ViewBag.Error = "StudentID and password are required";
                return View();
            }

            var student = _context.Students
                .FirstOrDefault(s => s.StudentID == studentID.Trim());

            if (student == null)
            {
                ViewBag.Error = "StudentID not found";
                return View();
            }

            bool isPasswordValid = BCrypt.Net.BCrypt.Verify(password, student.Password);

            if (!isPasswordValid)
            {
                ViewBag.Error = "Invalid password";
                return View();
            }

            HttpContext.Session.SetString("StudentID", student.StudentID);
            HttpContext.Session.SetString("FirstName", student.FirstName);

            return RedirectToAction("PurchaseHistory");
        }

        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult TopUpHistory() 
        {
            var studentID = HttpContext.Session.GetString("StudentID");
            if (studentID == null)
            {
                return RedirectToAction("Login");
            }

            var history = _context.TopUpLogs
                .Where(t => t.StudentID == studentID)
                .OrderByDescending(t => t.TopUpDate)
                .ToList();

            return View(history);
        }

        public IActionResult PurchaseHistory()
        {
            var studentID = HttpContext.Session.GetString("StudentID");
            if (studentID == null)
                return RedirectToAction("Login");

            var transactions = _context.Transactions
                .Where(t => t.StudentID == studentID)
                .OrderByDescending(t => t.SaleDate)
                .ToList();

            var currentBalance = _context.Balance
                .Where(b => b.StudentID == studentID)
                .Select(b => b.StudentBalance)
                .FirstOrDefault();

            var totalToppedUp = _context.TopUpLogs
                .Where(t => t.StudentID == studentID)
                .Sum(t => t.Amount);

            ViewBag.CurrentBalance = currentBalance;
            ViewBag.TotalToppedUp = totalToppedUp;

            return View(transactions);
        }

        public JsonResult GetTransactionDetails(string referenceId)
        {
            if (string.IsNullOrEmpty(referenceId))
                return Json(new { });

            var details = _context.TransactionDetails
             .Where(d => d.ReferenceID == referenceId)
             .Select(d => new
             {
                 productName = d.Product.ProductName,
                 quantitySold = d.QuantitySold,
                 unitPrice = d.UnitPrice,
                 subtotal = d.Subtotal
             }).ToList();

            return Json(details);
        }

        [HttpGet]
        public IActionResult Logout()
        {  
            HttpContext.Session.Clear();

            return RedirectToAction("Login");
        }

    }
}
