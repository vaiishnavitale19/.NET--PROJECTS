using _24July.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Diagnostics;

namespace _24July.Controllers
{
    public class HomeController : Controller
    {
        // GET : Login
        public IActionResult Index()
        {
            return View();
        }

        // POST : Login
        [HttpPost]
        public ActionResult Index(Student student)
        {
            if (ModelState.IsValid)
            {
                if (student.Username == "admin" && student.Password == "12345678")
                {
                    HttpContext.Session.SetString("User", student.Username);
                    return RedirectToAction("Dashboard");
                }

                ViewBag.Error = "Invalid username or password";
            }

            return View(student);
        }

        // Dashboard
        public ActionResult Dashboard()
        {
            var user = HttpContext.Session.GetString("User");

            if (string.IsNullOrEmpty(user))
            {
                return RedirectToAction("Index");
            }

            ViewBag.User = user;

            List<Notice> notices = new List<Notice>()
            {
                new Notice
                {
                    Id = 1,
                    Title = "ASP.NET MVC Practical Submission",
                    Date = "30/07/2026"
                },

                new Notice
                {
                    Id = 2,
                    Title = "Unit Test Starts",
                    Date = "05/08/2026"
                },

                new Notice
                {
                    Id = 3,
                    Title = "Project Viva",
                    Date = "10/08/2026"
                }
            };

            return View(notices);
        }

        // Logout
        public ActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}