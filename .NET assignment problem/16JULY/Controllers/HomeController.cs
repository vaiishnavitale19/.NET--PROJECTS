using _16_jul2.Models;
using Microsoft.AspNetCore.Mvc;

namespace _16_jul2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new EmployeeDepartmentViewModel
            {
                Employees = new List<Employee>()
                {
                    new Employee
                    {
                        EmployeeId = 101,
                        Name = "Vaishnavi",
                        Department = "CSE",
                        Salary = 50000,
                        Email = "vaishnavi@gmail.com"
                    },
                    new Employee
                    {
                        EmployeeId = 102,
                        Name = "Vira",
                        Department = "IT",
                        Salary = 45000,
                        Email = "vira@gmail.com"
                    }
                },

                Departments = new List<Department>()
                {
                    new Department
                    {
                        DeptName = "CSE",
                        DepartmentHead = "Dr. Sharma",
                        HeadContact = "9876543210",
                        HeadEmail = "sharma@gmail.com"
                    },
                    new Department
                    {
                        DeptName = "IT",
                        DepartmentHead = "Dr. Patil",
                        HeadContact = "9988776655",
                        HeadEmail = "patil@gmail.com"
                    }
                }
            };

            return View(model);
        }
    }
}