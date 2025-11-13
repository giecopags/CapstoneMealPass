using MealPass.Core.Entity;
using MealPass.Core.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPass.Business.Services
{
    public class PurchaseService
    {
        private readonly IStudentRepository _studentRepo;
        private readonly IBalanceRepository _balanceRepo;
        private readonly ITransactionRepository _transactionRepo;
        private readonly IProductRepository _productRepo;

        public PurchaseService(
        IStudentRepository studentRepository,
        IBalanceRepository balanceRepository,
        ITransactionRepository transactionRepository,
        IProductRepository productRepository)
        {
            _studentRepo = studentRepository;
            _balanceRepo = balanceRepository;
            _transactionRepo = transactionRepository;
            _productRepo = productRepository;
        }

        public async Task<(Student student, Balance balance)> LoadStudentForRFIDPayment(string rfid)
        {
            var student = await _studentRepo.GetStudentByRFIDAsync(rfid);
            if (student == null)
                return (null, null);

            var balance = await _balanceRepo.GetBalanceByStudentIDAsync(student.StudentID);
            return (student, balance);
        }

        public async Task<bool> ProcessRFIDPurchaseAsync(
        string studentId,
        string username,
        DataTable cartItems,
        decimal totalAmount)
        {
            // Get balance
            var balance = await _balanceRepo.GetBalanceByStudentIDAsync(studentId);
            if (balance == null) return false;

            if (balance.StudentBalance < totalAmount)
                return false;

            // Deduct balance
            decimal newBalance = balance.StudentBalance - totalAmount;
            await _balanceRepo.UpdateBalanceAsync(studentId, newBalance);

            // Create Reference ID
            string referenceId = GenerateReferenceID("R", studentId);

            // Insert main transaction record
            var transaction = new Transaction
            {
                ReferenceID = referenceId,
                SaleDate = DateTime.Now,
                StudentID = studentId,
                Username = username,
                TotalAmount = totalAmount,
                PaymentMethod = 0,   // RFID = true
                Remarks = "Completed"
            };

            await _transactionRepo.InsertTransactionAsync(transaction);

            // Insert details + deduct stock
            foreach (DataRow row in cartItems.Rows)
            {
                int productId = Convert.ToInt32(row["ID"]);
                int qty = Convert.ToInt32(row["Quantity"]);
                decimal price = Convert.ToDecimal(row["Price"]);
                decimal subtotal = Convert.ToDecimal(row["Total"]);

                // Insert detail row
                var detail = new TransactionDetail
                {
                    ReferenceID = referenceId,
                    ProductID = productId,
                    QuantitySold = qty,
                    UnitPrice = price,
                    Subtotal = subtotal
                };

                await _transactionRepo.InsertTransactionDetailAsync(detail);

                // Deduct stock
                await _productRepo.DeductStockAsync(productId, qty);
            }

            return true;
        }

        private string GenerateReferenceID(string prefix, string studentId)
        {
            string suffix = studentId.Length >= 4 ? studentId.Substring(studentId.Length - 4) : studentId;
            string datetime = DateTime.Now.ToString("yyMMddHHmmss");
            return prefix + datetime + suffix;
        }
    }
}
