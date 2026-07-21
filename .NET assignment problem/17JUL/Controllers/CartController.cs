using Microsoft.AspNetCore.Mvc;
using _17jul_ShopEase.Models;

namespace _17jul_ShopEase.Controllers
{
    public class CartController : Controller
    {
        static List<Cart> carts = new List<Cart>();

        // View Cart
        public IActionResult Index()
        {
            ViewBag.Total = carts.Sum(c => c.Price * c.Quantity);

            return View(carts);
        }

        // Open Add Cart Page
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        // Save Cart Item
        [HttpPost]
        public IActionResult Add(Cart cart)
        {
            carts.Add(cart);

            return RedirectToAction("Index");
        }
        public IActionResult Remove(string productName)
        {
            var item = carts.FirstOrDefault(c => c.ProductName == productName);

            if (item != null)
            {
                carts.Remove(item);
            }

            return RedirectToAction("Index");
        }
    }
}