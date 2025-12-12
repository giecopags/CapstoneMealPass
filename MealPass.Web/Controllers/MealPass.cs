using Microsoft.AspNetCore.Mvc;
using MealPass.Web.Models;
using MealPass.Shared.Models;
using System.Net.Http.Json;
using Student = MealPass.Shared.Models.Student;
using TopUpLogs = MealPass.Shared.Models.TopUpLogs;
using Balance = MealPass.Shared.Models.Balance;
using Transactions = MealPass.Shared.Models.Transactions;
using TransactionDetails = MealPass.Shared.Models.TransactionDetails;

namespace MealPass.Web.Controllers
{
    public class MealPassController : Controller
    {
        private readonly HttpClient _httpClient;
        public MealPassController(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("MealPassAPI");
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(string studentID, string password)
        {
            if (string.IsNullOrEmpty(studentID) || string.IsNullOrEmpty(password))
            {
                ViewBag.Error = "StudentID and password are required";
                return View();
            }

            // Call API to get student
            var response = await _httpClient.GetAsync($"students/{studentID.Trim()}");

            if (!response.IsSuccessStatusCode)
            {
                ViewBag.Error = "StudentID not found";
                return View();
            }

            var student = await response.Content.ReadFromJsonAsync<Student>();

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

        public async Task<IActionResult> TopUpHistory() 
        {
            var studentID = HttpContext.Session.GetString("StudentID");
            if (studentID == null) return RedirectToAction("Login");

            var history = await _httpClient.GetFromJsonAsync<List<TopUpLogs>>($"topuplogs/{studentID}");

            var balance = await _httpClient.GetFromJsonAsync<Balance>($"balance/{studentID}");
            ViewBag.IsLocked = balance != null && balance.IsLocked == 1;

            return View(history);
        }

        public async Task<IActionResult> PurchaseHistory()
        {
            var studentID = HttpContext.Session.GetString("StudentID");
            if (studentID == null) return RedirectToAction("Login");

            var transactions = await _httpClient.GetFromJsonAsync<List<Transactions>>($"transactions/{studentID}");
            var balance = await _httpClient.GetFromJsonAsync<Balance>($"balance/{studentID}");

            var topUpLogs = await _httpClient.GetFromJsonAsync<List<TopUpLogs>>($"topuplogs/{studentID}");
            var totalToppedUp = topUpLogs.Sum(t => t.Amount);

            ViewBag.CurrentBalance = balance?.StudentBalance ?? 0;
            ViewBag.TotalToppedUp = totalToppedUp;

            return View(transactions);
        }

        public async Task<JsonResult> GetTransactionDetails(string referenceId)
        {
            if (string.IsNullOrEmpty(referenceId)) return Json(new { });

            var details = await _httpClient.GetFromJsonAsync<List<TransactionDetails>>($"transactions/details/{referenceId}");

            return Json(details);
        }

        //[HttpPost]
        //public async Task<JsonResult> ToggleAccountLock([FromBody] int isLocked)
        //{
        //    var studentID = HttpContext.Session.GetString("StudentID");
        //    if (string.IsNullOrEmpty(studentID))
        //        return Json(new { success = false, message = "Not logged in" });

        //    var response = await _httpClient.PostAsJsonAsync($"Balance/togglelock/{studentID}", new { IsLocked = isLocked });
        //    var data = await response.Content.ReadFromJsonAsync<ToggleLockRequest>();

        //    if (data == null)
        //        return Json(new { success = false, message = "Failed to toggle lock" });

        //    return Json(new
        //    {
        //        success = true,
        //        isLocked = data.IsLocked
        //    });
        //}

        [HttpPost]
        public async Task<JsonResult> ToggleAccountLock([FromBody] int isLocked)
        {
            var studentID = HttpContext.Session.GetString("StudentID");
            if (string.IsNullOrEmpty(studentID))
                return Json(new { success = false, message = "Not logged in" });

            // Call the API
            var response = await _httpClient.PostAsJsonAsync(
                $"Balance/togglelock/{studentID}",
                new { IsLocked = isLocked } // matches your API payload
            );

            var data = await response.Content.ReadFromJsonAsync<ToggleLockRequest>();

            if (data == null)
                return Json(new { success = false, message = "Failed to toggle lock" });

            return Json(new { success = true, isLocked = data.IsLocked });
        }

        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }

    }
}
