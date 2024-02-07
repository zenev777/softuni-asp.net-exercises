using Microsoft.AspNetCore.Mvc;
using MyShop.Contracts;

namespace MyShop.Controllers
{
    public class Productcontroller : Controller
    {
        private readonly IProductService productService;

        public Productcontroller(IProductService _productService)
        {
            productService = _productService;
        }

        public async Task<IActionResult> Index()
        {
            var model = await productService.GetAllAsync();


            return View(model);
        }
    }
}
