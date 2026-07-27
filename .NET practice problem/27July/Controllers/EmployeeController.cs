using _27July.Controllers.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _27July.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        static List<Employee> employees = new List<Employee>()
        {
            
          new Employee() { Id = 101, Name = "Mamta", LastName = "B", Dept = "IT", PhoneNum = 789654 },
          new Employee() { Id = 102, Name = "John", LastName = "Amit", Dept = "IT", PhoneNum = 890654 },
          new Employee() { Id = 103, Name = "Bob", LastName = "Alice", Dept = "Admin", PhoneNum = 700054 },
            
        };

        //get all employee list
        [HttpGet]
        public IActionResult getEmployee()
        {
            return Ok(employees);   // Ok - 200
        }

        //get employee by id
        [HttpGet("{id}")]
        public IActionResult getEmployeeById(int id)
        {
            var employee = employees.FirstOrDefault(x => x.Id == id);

            if (employee == null)
            {
                return NotFound();
            }

            return Ok(employee);
        }

        //add new employee record
        [HttpPost]
        public IActionResult AddEmployee(Employee employee)
        {
            employees.Add(employee);

            return Ok(employee);
        }
        // Edit employee record
        [HttpPut("{id}")]
        public IActionResult UpdateEmployee(int id, Employee employee)
        {
            var employee1 = employees.FirstOrDefault(x => x.Id == id);

            if (employee1 == null)
            {
                return NotFound();
            }

            employee1.LastName = employee.LastName;

            return Ok(employee1);
        }


        // Get employees by department
        [HttpGet("Dept/{dept}")]
        public IActionResult GetEmployeeByDept(string dept)
        {
            var result = employees.Where(s => s.Dept.Equals(dept, StringComparison.OrdinalIgnoreCase)).ToList();

            if (!result.Any())
            {
                return NotFound("No employee found under this department.");
            }

            return Ok(result);
        }
        // Get employee by name
        [HttpGet("Name/{name}")]
        public IActionResult GetEmployeeByName(string name)
        {
            var result = employees.Where(s => s.Name.Equals(name, StringComparison.OrdinalIgnoreCase)).ToList();

            if (!result.Any())
            {
                return NotFound("No employee found with this name.");
            }

            return Ok(result);
        }
        // Delete employee record
        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            var employee1 = employees.FirstOrDefault(x => x.Id == id);

            if (employee1 == null)
            {
                return NotFound();
            }

            employees.Remove(employee1);

            return Ok(employee1);
        }


    }
}
