using _21Jul.Models;
using Microsoft.AspNetCore.Mvc;

namespace _21Jul.Controllers
{
    public class HomeController : Controller
    {
        // Display Form
        public IActionResult Register()
        {
            return View();
        }

        // Handle Form Submission
        [HttpPost]
        public IActionResult Register(Student student)
        {
            if (ModelState.IsValid)
            {
                TempData["StudentName"] = student.Name;
                return RedirectToAction("Schedule");
            }

            return View(student);
        }

        // Course Schedule Page
        public IActionResult Schedule()
        {
            List<Course> courses = new List<Course>()
            {
                new Course
                {
                    CourseName = "ASP.NET",
                    Semester = "Sem 3",
                    SessionTime = "9:30 AM - 12:00 PM",
                    Days = "Mon - Tue"
                },

                new Course
                {
                    CourseName = "Java",
                    Semester = "Sem 3",
                    SessionTime = "9:30 AM - 11:00 AM",
                    Days = "Tue - Wed"
                },

                new Course
                {
                    CourseName = "HTML",
                    Semester = "Sem 3",
                    SessionTime = "9:30 AM - 11:00 AM",
                    Days = "Fri - Sat"
                }
            };

            return View(courses);
        }
    }
}