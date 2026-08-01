using _29July.Models;
using _29July.Services;
using Microsoft.AspNetCore.Mvc;

namespace _29July.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _service;

        public EmployeeController(IEmployeeService service)
        {
            _service = service;
        }

        // Get All Employees
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.GetEmployees());
        }

        // Get Employee by Department Id
        [HttpGet("dept/{deptid}")]
        public IActionResult GetById(int deptid)
        {
            var employee = _service.GetEmployee(deptid);

            if (employee == null)
                return NotFound("Employee with Department Id not found");

            return Ok(employee);
        }

        // Get Employee by Name
        [HttpGet("name/{name}")]
        public IActionResult GetByName(string name)
        {
            var employee = _service.GetEmployeeName(name);

            if (employee == null)
                return NotFound("Employee with name not found");

            return Ok(employee);
        }

        // Add Employee
        [HttpPost]
        public IActionResult AddEmployee(Employee employee)
        {
            var result = _service.AddEmployee(employee);
            return Ok(result);
        }
    }
}