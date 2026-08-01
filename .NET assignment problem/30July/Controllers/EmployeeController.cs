using _30July_assignment.Models;
using _30July_assignment.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _30July_assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(employeeService.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var employee = employeeService.GetById(id);

            if (employee == null)
                return NotFound("Employee not found");

            return Ok(employee);
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = employeeService.Add(employee);

            return CreatedAtAction(
                nameof(GetById),
                new { id = result.EmployeeId },
                result
            );
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Employee employee)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = employeeService.Update(id, employee);

            if (!result)
                return NotFound("Employee not found");

            return Ok("Employee updated successfully");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = employeeService.Delete(id);

            if (!result)
                return NotFound("Employee not found");

            return Ok("Employee deleted successfully");
        }

        [HttpGet("search")]
        public IActionResult Search(
            string name = null,
            string department = null,
            string email = null,
            int? employeeId = null,
            string status = null)
        {
            var result = employeeService.Search(
                name,
                department,
                email,
                employeeId,
                status);

            return Ok(result);
        }

        [HttpGet("department/{departmentId}")]
        public IActionResult GetByDepartment(int departmentId)
        {
            var result = employeeService.GetByDepartment(departmentId);

            return Ok(result);
        }
    }

    }

