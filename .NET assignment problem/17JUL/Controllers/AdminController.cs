using Microsoft.AspNetCore.Mvc;

namespace _17jul_ShopEase.Controllers
{
    public class AdminController : Controller
    {
        // Login Page
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        // Login Button Click
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            if (username == "admin" && password == "admin123")
            {
                return RedirectToAction("Dashboard");
            }

            ViewBag.Message = "Invalid Username or Password";
            return View();
        }

        // Dashboard
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}