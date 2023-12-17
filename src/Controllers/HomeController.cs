using Microsoft.AspNetCore.Mvc;

namespace lr9.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            var products = new List<Product>()
            {
                new() { Id = 1, Name = "Product1", Price = 10.99m },
                new() { Id = 2, Name = "Product2", Price = 20.49m },
                new() { Id = 3, Name = "Product3", Price = 15.79m },
                new() { Id = 4, Name = "Product4", Price = 5.99m },
                new() { Id = 5, Name = "Product5", Price = 8.50m },
                new() { Id = 6, Name = "Product6", Price = 12.25m }
            };

            ViewBag.City = "Paris";

            return View(products);
        }
    }
}
