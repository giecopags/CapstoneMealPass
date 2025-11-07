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
        Task<DataRow> GetByIdWithDetailsAsync(int productId);
        Task UpdateAsync(Product product);
        Task DeleteAsync(int id);
        Task<DataTable> GetAllWithDetailsAsync();

        // Centralized stock status calculation
        int CalculateStockStatus(int quantity, int lowStockLevel);

        // Easier product update by fields
        Task UpdateProductAsync(int productId, string name, int categoryId, decimal price, int quantity, int lowStockLevel, int stockStatusId);
    }
}
