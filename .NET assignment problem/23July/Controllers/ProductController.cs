using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using _23July_Assignment.Models;

namespace _23July_Assignment.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("User")))
            {
                return RedirectToAction("Index", "Home");
            }

            List<Product> products = new List<Product>()
            {
                new Product { Id = 1, Name = "Pen", Price = 10 },
                new Product { Id = 2, Name = "Pencil", Price = 5 },
                new Product { Id = 3, Name = "Notebook", Price = 40 },
                new Product { Id = 4, Name = "Eraser", Price = 3 },
                new Product { Id = 5, Name = "Ruler", Price = 8 },
                new Product { Id = 6, Name = "Stapler", Price = 60 }
            };

            return View(products);
        }
    }
}