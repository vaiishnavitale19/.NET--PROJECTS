using Microsoft.AspNetCore.Mvc;
using _17jul_ShopEase.Models;

namespace _17jul_ShopEase.Controllers
{
    public class PaymentController : Controller
    {
        // Open Payment Page
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        // Payment Button Click
        [HttpPost]
        public IActionResult Index(Payment payment)
        {
            payment.Status = "Success";

            return View("Success", payment);
        }

        // Success Page
        public IActionResult Success(Payment payment)
        {
            return View(payment);
        }
    }
}