using _30July_assignment.Models;
using _30July_assignment.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _30July_assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentService departmentService;

        public DepartmentController(IDepartmentService departmentService)
        {
            this.departmentService = departmentService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(departmentService.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var department = departmentService.GetById(id);

            if (department == null)
                return NotFound("Department not found");

            return Ok(department);
        }

        [HttpPost]
        public IActionResult Create(Department department)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = departmentService.Add(department);

            return CreatedAtAction(
                nameof(GetById),
                new { id = result.DepartmentId },
                result
            );
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Department department)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = departmentService.Update(id, department);

            if (!result)
                return NotFound("Department not found");

            return Ok("Department updated successfully");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = departmentService.Delete(id);

            if (!result)
                return NotFound("Department not found");

            return Ok("Department deleted successfully");
        }
    }
}

