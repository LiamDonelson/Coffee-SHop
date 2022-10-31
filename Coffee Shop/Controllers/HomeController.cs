using Coffee_Shop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Coffee_Shop.Controllers
{
    public class HomeController : Controller
    {
        CoffeeShopContext db = new CoffeeShopContext();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Registration()
        {
            return View();
        }

        public IActionResult ProductList()
        {
            List<Product> Products = db.Products.ToList();
            return View(Products);
        }

        public IActionResult Registered(RegistrationClass registrationClass)
        {
            return View(registrationClass);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}