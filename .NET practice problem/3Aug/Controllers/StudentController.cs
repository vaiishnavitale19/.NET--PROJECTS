using _3Aug.Models;
using _3Aug.Repository;
using Microsoft.AspNetCore.Mvc;

namespace _3Aug.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _service;

        public StudentController(IStudentService service)
        {
            _service = service;
        }

        // GET: api/Student
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.GetAll());
        }

        // GET: api/Student/1
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var student = _service.GetStudent(id);

            if (student == null)
            {
                return NotFound("Student not found");
            }

            return Ok(student);
        }

        // POST: api/Student
        [HttpPost]
        public IActionResult Post(Student student)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _service.AddStudent(student);

            return Ok(student);
        }

        // PUT: api/Student/1
        [HttpPut("{id}")]
        public IActionResult Put(int id, Student student)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var existing = _service.GetStudent(id);

            if (existing == null)
            {
                return NotFound("Student not found");
            }

            student.Id = id;

            _service.UpdateStudent(student);

            return Ok(student);
        }

        // DELETE: api/Student/1
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var student = _service.GetStudent(id);

            if (student == null)
            {
                return NotFound("Student not found");
            }

            _service.DeleteStudent(id);

            return Ok("Student deleted successfully");
        }
    }
}