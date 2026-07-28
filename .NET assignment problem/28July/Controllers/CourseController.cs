using _28July_Assignment.Models;
using _28July_Assignment.Services;
using Microsoft.AspNetCore.Mvc;

namespace _28July_Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService service;

        public CourseController(ICourseService service)
        {
            this.service = service;
        }

        // GET : api/course
        [HttpGet]
        public IActionResult GetCourses()
        {
            return Ok(service.GetCourses());
        }

        // GET : api/course/1
        [HttpGet("{id}")]
        public IActionResult GetCourse(int id)
        {
            var course = service.GetCourse(id);

            if (course == null)
                return NotFound();

            return Ok(course);
        }

        // POST : api/course
        [HttpPost]
        public IActionResult AddCourse(Course course)
        {
            service.AddCourse(course);
            return Ok(course);
        }

        // PUT : api/course/1
        [HttpPut("{id}")]
        public IActionResult UpdateCourse(int id, Course course)
        {
            service.UpdateCourse(id, course);
            return NoContent();
        }

        // DELETE : api/course/1
        [HttpDelete("{id}")]
        public IActionResult DeleteCourse(int id)
        {
            service.DeleteCourse(id);
            return NoContent();
        }
    }
}