using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPass.Data.Queries
{
    public static class DashboardQuery
    {
        // Total Sales Per Month
        public const string GetMonthlySales = @"
            SELECT 
                FORMAT(SaleDate, 'MMM') AS Month,
                SUM(TotalAmount) AS TotalSale
            FROM Transactions
            GROUP BY FORMAT(SaleDate, 'MMM'), MONTH(SaleDate)
            ORDER BY MONTH(MIN(SaleDate));
        ";

        // Total Top-Ups Per Month
        public const string GetMonthlyTopUps = @"
            SELECT 
                FORMAT(TopUpDate, 'MMM') AS Month,
                SUM(Amount) AS TotalTopUp
            FROM TopUpLogs
            GROUP BY FORMAT(TopUpDate, 'MMM'), MONTH(TopUpDate)
            ORDER BY MONTH(MIN(TopUpDate));
        ";

        public const string GetTopBestSellersThisMonth = @"
            SELECT TOP 3
                p.ProductName,
                SUM(td.QuantitySold) AS TotalQuantitySold,
                SUM(td.Subtotal) AS TotalAmount
            FROM TransactionDetails td
            INNER JOIN pro.Products p ON p.ProductID = td.ProductID
            INNER JOIN Transactions t ON t.ReferenceID = td.ReferenceID
            WHERE MONTH(t.SaleDate) = MONTH(GETDATE())
              AND YEAR(t.SaleDate) = YEAR(GETDATE())
            GROUP BY p.ProductName
            ORDER BY TotalAmount DESC;
        ";

        public const string GetTopBestSellersByMonth = @"
            SELECT TOP 3
                p.ProductName,
                SUM(td.QuantitySold) AS TotalQuantitySold,
                SUM(td.Subtotal) AS TotalAmount
            FROM TransactionDetails td
            INNER JOIN pro.Products p ON p.ProductID = td.ProductID
            INNER JOIN Transactions t ON t.ReferenceID = td.ReferenceID
            WHERE MONTH(t.SaleDate) = @Month
              AND YEAR(t.SaleDate) = @Year
            GROUP BY p.ProductName
            ORDER BY TotalQuantitySold DESC;
        ";
    }
}
