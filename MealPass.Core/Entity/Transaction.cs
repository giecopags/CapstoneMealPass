using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPass.Core.Entity
{
    public class Transaction
    {
        public string ReferenceID { get; set; }      // R/M/C + datetime + last 4 chars of StudentID
        public DateTime SaleDate { get; set; }       // Date of transaction
        public string StudentID { get; set; }        // FK → Student.StudentID
        public string Username { get; set; }         // Cashier username
        public decimal TotalAmount { get; set; }     // Total amount purchased
        public int PaymentMethod { get; set; }      // 0 = Cash, 1 = RFID
        public string Remarks { get; set; }          // Completed / Canceled
    }
}
