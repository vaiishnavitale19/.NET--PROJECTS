using _16jul.Models;
using Microsoft.AspNetCore.Mvc;

namespace _16jul.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Student> students = new List<Student>()
            {
                new Student
                {
                    Id = 101,
                    Name = "Vira",
                    Age = 20,
                    Course = "Dot Net Framework",
                    Branch = "CSE",
                    Gender = 'F',
                    Fees = 20000
                },

                new Student
                {
                    Id = 102,
                    Name = "Riya",
                    Age = 19,
                    Course = "Java Framework",
                    Branch = "Mech",
                    Gender = 'F',
                    Fees = 30000
                },

                new Student
                {
                    Id = 103,
                    Name = "Piya",
                    Age = 20,
                    Course = "Frontend Framework",
                    Branch = "ELPO",
                    Gender = 'F',
                    Fees = 70000
                },

                new Student
                {
                    Id = 104,
                    Name = "Khushi",
                    Age = 21,
                    Course = "Java Framework",
                    Branch = "IT",
                    Gender = 'F',
                    Fees = 80000
                }
            };

            return View(students);
        }
    }
}