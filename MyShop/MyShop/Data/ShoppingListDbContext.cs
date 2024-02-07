using Microsoft.EntityFrameworkCore;
using MyShop.Data.Models;

namespace MyShop.Data
{
    public class ShoppingListDbContext : DbContext
    {
        public ShoppingListDbContext (DbContextOptions<ShoppingListDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasData(new Product() { Id = 1, Name = "Cheese"},
                         new Product() { Id = 2, Name = "Pizza" });
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductNote> ProductNotes { get; set; }


    }
}
