using MealPass.Core.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPass.Core.Interface
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllAsync();
        Task<Product> GetByIdAsync(int id);
        Task AddAsync(Product product);
        Task UpdateAsync(Product product);
        Task DeleteAsync(int id);

        // Add this:
        Task<DataRow> GetByIdWithDetailsAsync(int productId);

        Task<DataTable> GetAllWithDetailsAsync();
        int CalculateStockStatus(int quantity, int lowStockLevel);
        Task UpdateProductAsync(int productId, string name, int categoryId, decimal price, int quantity, int lowStockLevel, int stockStatusId);
        Task DeductStockAsync(int productId, int quantity);
    }
}
