using System;
using Microsoft.EntityFrameworkCore;


namespace MealPass.Web.Models
{
    public class MealPassDBContext : DbContext
    {
        public MealPassDBContext(DbContextOptions<MealPassDBContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<TopUpLogs> TopUpLogs { get; set; }
        public DbSet<Transactions> Transactions { get; set; }

        public DbSet<TransactionDetails> TransactionDetails { get; set; }

        public DbSet<Products> Products { get; set; } 

        public DbSet<Balance> Balance { get; set; }
    }
}
