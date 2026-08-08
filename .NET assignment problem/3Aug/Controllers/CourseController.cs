using _3Aug.Models;
using _3Aug.Repository;
using Microsoft.AspNetCore.Mvc;

namespace _3Aug.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _service;

        public CourseController(ICourseService service)
        {
            _service = service;
        }

        // GET: api/Course
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.GetAll());
        }

        // GET: api/Course/1
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var course = _service.GetCourse(id);

            if (course == null)
            {
                return NotFound("Course not found");
            }

            return Ok(course);
        }

        // POST: api/Course
        [HttpPost]
        public IActionResult Post(Course course)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _service.AddCourse(course);

            return Ok(course);
        }

        // PUT: api/Course/1
        [HttpPut("{id}")]
        public IActionResult Put(int id, Course course)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var existing = _service.GetCourse(id);

            if (existing == null)
            {
                return NotFound("Course not found");
            }

            course.Id = id;

            _service.UpdateCourse(course);

            return Ok(course);
        }

        // DELETE: api/Course/1
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var existing = _service.GetCourse(id);

            if (existing == null)
            {
                return NotFound("Course not found");
            }

            _service.DeleteCourse(id);

            return Ok("Course deleted successfully");
        }
    }
}