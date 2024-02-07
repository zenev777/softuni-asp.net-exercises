using MyShop.Models;

namespace MyShop.Contracts
{
    public interface IProductService
    {
        Task<IEnumerable<ProductViewModel>> GetAllAsync();

        Task<ProductViewModel> GetByIdAsync(int id);
    
        Task AddProductAsync(ProductViewModel model);

        Task UpdateProductAsync(ProductViewModel model);

        Task DelateProductAsync(int Id);
    }
}
