using Microsoft.EntityFrameworkCore;
using MyShop.Contracts;
using MyShop.Data;
using MyShop.Models;

namespace MyShop.Services
{
    public class ProductService : IProductService
    {
        private readonly ShoppingListDbContext context;

        public ProductService(ShoppingListDbContext _context)
        {
            context = _context;
        }

        public Task AddProductAsync(ProductViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task DelateProductAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ProductViewModel>> GetAllAsync()
        {
            return await context.Products
                .AsNoTracking()
                .Select(p=>new ProductViewModel()
                {
                    Id = p.Id,
                    Name = p.Name,
                })
                .ToListAsync();
        }

        public Task<ProductViewModel> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateProductAsync(ProductViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}
