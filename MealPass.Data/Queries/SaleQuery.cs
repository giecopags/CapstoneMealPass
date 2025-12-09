using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPass.Data.Queries
{
    public class SaleQuery
    {
        public const string GetAllSalesSummary = @"
        SELECT 
            p.ProductID,
            p.ProductName,
            c.CategoryName,
            td.UnitPrice,
            SUM(td.QuantitySold) AS ItemSold,
            SUM(td.Subtotal) AS TotalAmount
        FROM pro.Products p
        LEFT JOIN pro.Category c ON p.CategoryID = c.CategoryID
        LEFT JOIN TransactionDetails td ON td.ProductID = p.ProductID
        LEFT JOIN Transactions t ON t.ReferenceID = td.ReferenceID
        GROUP BY 
            p.ProductID,
            p.ProductName,
            c.CategoryName,
            td.UnitPrice
        HAVING SUM(td.QuantitySold) > 0
        ORDER BY 
            p.ProductName ASC, td.UnitPrice ASC;
    ";

        public const string GetSalesSummaryByDate = @"
        SELECT 
            p.ProductID,
            p.ProductName,
            c.CategoryName,
            td.UnitPrice,
            SUM(td.QuantitySold) AS ItemSold,
            SUM(td.Subtotal) AS TotalAmount
        FROM pro.Products p
        LEFT JOIN pro.Category c ON p.CategoryID = c.CategoryID
        LEFT JOIN TransactionDetails td ON td.ProductID = p.ProductID
        LEFT JOIN Transactions t ON t.ReferenceID = td.ReferenceID
        WHERE CAST(t.SaleDate AS DATE) = @Date
        GROUP BY 
            p.ProductID,
            p.ProductName,
            c.CategoryName,
            td.UnitPrice
        ORDER BY 
            p.ProductName ASC, td.UnitPrice ASC;
    ";

        public const string GetSalesSummaryByDateTimeRange = @"
      SELECT 
            p.ProductID,
            p.ProductName,
            c.CategoryName,
            td.UnitPrice,
            SUM(td.QuantitySold) AS ItemSold,
            SUM(td.Subtotal) AS TotalAmount
        FROM pro.Products p
        LEFT JOIN pro.Category c ON p.CategoryID = c.CategoryID
        INNER JOIN TransactionDetails td ON td.ProductID = p.ProductID
        INNER JOIN Transactions t ON td.ReferenceID = t.ReferenceID
        WHERE t.SaleDate BETWEEN @FromDateTime AND @ToDateTime
        GROUP BY 
            p.ProductID,
            p.ProductName,
            c.CategoryName,
            td.UnitPrice
        HAVING SUM(td.QuantitySold) > 0
        ORDER BY 
            p.ProductName ASC, td.UnitPrice ASC;
        ";

    }
}
