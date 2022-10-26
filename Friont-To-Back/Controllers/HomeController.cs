using Friont_To_Back.Models;
using Microsoft.AspNetCore.Mvc;

namespace Friont_To_Back.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>();
            products.Add(new Product()
            {
                Id = new Guid(),
                Name = "Xudi Gödəkçəsi Puma Iconic T7 Track Jacket PT (s)",
                Price = 82,
                Title = "Kişilər üçün Ds Damat, Puma, Adidas, LC Waikiki",
                ImgUrl= "https://static.shop.az/images/product/large/a0ec658c-dd23-4bfc-b26a-ccb1d0037540.jpg"
            });
            products.Add(new Product()
            {
                Id = new Guid(),
                Name = "Power Bank Xiaomi 10000mAh Mi Wireless (Black)",
                Price = 59,
                Title = "İki qurğunun eyni vaxtda yükləməsi",
                ImgUrl= "https://static.shop.az/images/product/large/4e8694ee-c760-45be-8b27-8b8a5c4a01fb.jpg"
            });
            products.Add(new Product()
            {
                Id = new Guid(),
                Name = "Telefon ücün keys Baseus Glitter Protecting Case(WIAPIPH65S-DW0S)",
                Price = 16,
                Title = "Apple iPhone 11 Pro",
                ImgUrl= "https://static.shop.az/images/product/large/cc1ac4c8-f088-4af6-951b-6feaafe5c359.jpg"

            });
            products.Add(new Product()
            {
                Id = new Guid(),
                Name = "Tozsoran Sonifer SF-2211",
                Price = 155,
                Title = "2100 Vt",
                ImgUrl= "https://static.shop.az/images/product/large/b8b60cc1-e0af-40fa-86b2-4e821057fd50.png"
            });



            return View(products);
        }
        public IActionResult Shop()
        {
            var products = new List<Product>();
            products.Add(new Product()
            {
                Id = new Guid(),
                Name = "Xudi Gödəkçəsi Puma Iconic T7 Track Jacket PT (s)",
                Price = 82,
                Title = "Kişilər üçün Ds Damat, Puma, Adidas, LC Waikiki",
                ImgUrl = "https://static.shop.az/images/product/large/a0ec658c-dd23-4bfc-b26a-ccb1d0037540.jpg"
            });
            products.Add(new Product()
            {
                Id = new Guid(),
                Name = "Power Bank Xiaomi 10000mAh Mi Wireless (Black)",
                Price = 59,
                Title = "İki qurğunun eyni vaxtda yükləməsi",
                ImgUrl = "https://static.shop.az/images/product/large/4e8694ee-c760-45be-8b27-8b8a5c4a01fb.jpg"
            });
            products.Add(new Product()
            {
                Id = new Guid(),
                Name = "Telefon ücün keys Baseus Glitter Protecting Case(WIAPIPH65S-DW0S)",
                Price = 16,
                Title = "Apple iPhone 11 Pro",
                ImgUrl = "https://static.shop.az/images/product/large/cc1ac4c8-f088-4af6-951b-6feaafe5c359.jpg"

            });
            products.Add(new Product()
            {
                Id = new Guid(),
                Name = "Tozsoran Sonifer SF-2211",
                Price = 155,
                Title = "2100 Vt",
                ImgUrl = "https://static.shop.az/images/product/large/b8b60cc1-e0af-40fa-86b2-4e821057fd50.png"
            });
            return View(products);
        }
    }
}
