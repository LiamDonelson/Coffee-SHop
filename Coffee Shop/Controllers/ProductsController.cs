using Coffee_Shop.Models;
using Microsoft.AspNetCore.Mvc;

namespace Coffee_Shop.Controllers
{
    public class ProductsController : Controller
    {
        CoffeeShopContext db = new CoffeeShopContext();

        public IActionResult Index()
        {
            List<Product> Products = db.Products.ToList();
            foreach (Product p in Products)
            {
              
            }

            return View();
        }

        public IActionResult Details()
        {
            return View();
        }
    }
}
