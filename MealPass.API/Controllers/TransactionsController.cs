using Microsoft.AspNetCore.Mvc;
using MealPass.API.Data;
using MealPass.Shared.Models;

namespace MealPass.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionsController : ControllerBase
    {
        private readonly MealPassDBContext _context;
        public TransactionsController(MealPassDBContext context)
        {
            _context = context;
        }

        [HttpGet("{studentID}")]
        public IActionResult GetTransactions(string studentID)
        {
            var transactions = _context.Transactions
                .Where(t => t.StudentID == studentID)
                .OrderByDescending(t => t.SaleDate)
                .ToList();

            return Ok(transactions);
        }

        [HttpGet("details/{referenceId}")]
        public IActionResult GetTransactionDetails(string referenceId)
        {
            var details = _context.TransactionDetails
                .Where(d => d.ReferenceID == referenceId)
                .Select(d => new
                {
                    d.Product.ProductName,
                    d.QuantitySold,
                    d.UnitPrice,
                    d.Subtotal
                })
                .ToList();

            return Ok(details);
        }
    }
}
