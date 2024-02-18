using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SoftUniBazar.Data;
using SoftUniBazar.Data.Models;
using SoftUniBazar.Models;
using System.Security.Claims;
using static SoftUniBazar.Data.Models.DataConstants;

namespace SoftUniBazar.Controllers
{
    [Authorize]
    public class AdController : Controller
    {
        private readonly BazarDbContext data;

        public AdController(BazarDbContext context)
        {
            data = context;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var model = await data.Ads
                .AsNoTracking()
                .Select(a => new AdsViewInfoModel()
                {
                    Id = a.Id,
                    Name = a.Name,
                    ImageUrl = a.ImageUrl,
                    CreatedOn = a.CreatedOn.ToString(DateFormat),
                    Category = a.Category.Name,
                    Description = a.Description,
                    Price = a.Price,
                    Owner = a.Owner.UserName
                })
                .ToListAsync();


            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddToCart(int id)
        {
            var ad = await data.Ads
                .FindAsync(id);

            if (ad == null)
            {
                return BadRequest();
            }

            string userId = GetUserId();

            var entry = new AdBuyer()
            {
                AdId = ad.Id,
                BuyerId = userId
            };

            if (await data.AdBuyers.ContainsAsync(entry))
            {
                return RedirectToAction("Cart");
            }

            await data.AdBuyers.AddAsync(entry);
            await data.SaveChangesAsync();

            return RedirectToAction("Cart");

        }

        [HttpGet]
        public async Task<IActionResult> Cart()
        {
            string userId = GetUserId();

            var model = await data.AdBuyers
                .Where(ab => ab.BuyerId == userId)
                .AsNoTracking()
                .Select(ab => new AdsViewInfoModel
                {
                    Id = ab.AdId,
                    Name = ab.Ad.Name,
                    ImageUrl = ab.Ad.ImageUrl,
                    Description = ab.Ad.Description,
                    Category = ab.Ad.Category.Name,
                    CreatedOn = ab.Ad.CreatedOn.ToString(DateFormat),
                    Price = ab.Ad.Price,
                    Owner = ab.Ad.Owner.UserName
                })
                .ToListAsync();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> RemoveFromCart(int id)
        {
            string userId = GetUserId();

            var ad = data.Ads
                .FindAsync(id);



            if (ad == null)
            {
                return BadRequest();
            }


            var entry = await data.AdBuyers
                .FirstOrDefaultAsync(ab => ab.BuyerId == userId && ab.AdId == id);


            data.AdBuyers.Remove(entry);

            await data.SaveChangesAsync();

            return RedirectToAction("All", "Ad");
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new AdsViewFormModel();

            model.Categories =  GetCategories();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(AdsViewFormModel model)
        {

            if (!GetCategories().Any(e => e.Id == model.CategoryId))
            {
                ModelState.AddModelError(nameof(model.CategoryId), "Category does not exist!");
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            string userId = GetUserId();

            var entry = new Ad()
            {
                Name = model.Name,
                ImageUrl = model.ImageUrl,
                CreatedOn = DateTime.Now,
                CategoryId = model.CategoryId,
                Description = model.Description,
                Price = model.Price,
                OwnerId = userId
            };

            await data.Ads.AddAsync(entry);

            await data.SaveChangesAsync();

            return RedirectToAction(nameof(All));

        }

        //private async Task<IEnumerable<CategoryViewModel>> GetCategories()
        //{
        //    return await data.Categories
        //        .Select(t => new CategoryViewModel()
        //        {
        //            Id = t.Id,
        //            Name = t.Name
        //        })
        //        .ToListAsync();
        //}

        private IEnumerable<CategoryViewModel> GetCategories()
            => data
                .Categories
                .Select(t => new CategoryViewModel()
                {
                    Id = t.Id,
                    Name = t.Name
                });

        private string GetUserId()
        {
            return User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;
        }
    }
}
