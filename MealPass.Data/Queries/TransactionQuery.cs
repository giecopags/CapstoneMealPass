using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPass.Data.Queries
{
    public class TransactionQuery
    {
        // Insert a master Transaction record
        public const string InsertTransaction = @"
            INSERT INTO Transactions (
                ReferenceID,
                SaleDate,
                StudentID,
                Username,
                TotalAmount,
                PaymentMethod,
                Remarks
            )
            VALUES (
                @ReferenceID,
                @SaleDate,
                @StudentID,
                @Username,
                @TotalAmount,
                @PaymentMethod,
                @Remarks
            );
        ";

        public const string InsertTransactionDetail = @"
            INSERT INTO TransactionDetails (
                ReferenceID,
                ProductID,
                QuantitySold,
                UnitPrice,
                Subtotal
            )
            VALUES (
                @ReferenceID,
                @ProductID,
                @QuantitySold,
                @UnitPrice,
                @Subtotal
            );
        ";
    }
}
