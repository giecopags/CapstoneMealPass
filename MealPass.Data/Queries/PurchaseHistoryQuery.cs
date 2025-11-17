using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPass.Data.Queries
{
    public static class PurchaseHistoryQuery
    {
        public const string GetAllPurchaseHistory = @"
            SELECT 
                ReferenceID,
                Username,
                StudentID,
                SaleDate,
                TotalAmount,
                PaymentMethod
            FROM Transactions
            ORDER BY SaleDate DESC";

        public const string GetPurchaseHistoryByDate = @"
            SELECT ReferenceID, Username, StudentID, SaleDate, TotalAmount, PaymentMethod
            FROM Transactions
            WHERE CAST(SaleDate AS DATE) = @Date
            ORDER BY SaleDate DESC";

        public const string GetPurchasedItemsByReferenceID = @"
            SELECT 
                p.ProductName,
                c.CategoryName,
                td.UnitPrice,
                td.QuantitySold,
                td.Subtotal
            FROM TransactionDetails td
            INNER JOIN pro.Products p ON p.ProductID = td.ProductID
            INNER JOIN pro.Category c ON c.CategoryID = p.CategoryID
            WHERE td.ReferenceID = @ReferenceID
            ORDER BY p.ProductName ASC;
";
    }
}
