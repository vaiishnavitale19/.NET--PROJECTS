using Microsoft.AspNetCore.Mvc;
using _17jul_ShopEase.Models;

namespace _17jul_ShopEase.Controllers
{
    public class CustomerController : Controller
    {
        // Temporary List
        static List<Customer> customers = new List<Customer>();

        // Register Page Open
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        // Register Button Click
        [HttpPost]
        public IActionResult Register(Customer customer)
        {
            customers.Add(customer);

            ViewBag.Message = "Registration Successful";

            return View();
        }
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
            var customer = customers.FirstOrDefault(c =>
                c.Username == username &&
                c.Password == password);

            if (customer != null)
            {
                ViewBag.Message = "Login Successful";
                return RedirectToAction("Profile");
            }

            ViewBag.Message = "Invalid Username or Password";
            return View();
        }
        
        

        public IActionResult Profile()
        {
            return View();
        }

        public IActionResult Logout()
        {
            return RedirectToAction("Login");
        }
    }
}