using Microsoft.AspNetCore.Mvc;
using _17jul_ShopEase.Models;

namespace _17jul_ShopEase.Controllers
{
    public class OrderController : Controller
    {
        static List<Order> orders = new List<Order>();

        // View Orders
        public IActionResult History()
        {
            return View(orders);
        }

        // Checkout Page
        [HttpGet]
        public IActionResult Checkout()
        {
            return View();
        }

        // Place Order
        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            orders.Add(order);

            return RedirectToAction("History");
        }
    }
}