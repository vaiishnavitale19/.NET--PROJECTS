using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace _23July_Assignment.Controllers
{
    public class HomeController : Controller
    {
        // Login Page
        public IActionResult Index()
        {
            return View();
        }

        // Login
        [HttpPost]
        public IActionResult Index(string username, string password)
        {
            if (username == "admin" && password == "12345")
            {
                HttpContext.Session.SetString("User", username);

                return RedirectToAction("Index", "Product");
            }

            ViewBag.Message = "Invalid Username or Password";

            return View();
        }

        // Logout
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();

            return RedirectToAction("Index");
        }
    }
}