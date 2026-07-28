using _28July_Assignment.Models;

namespace _28July_Assignment.Services
{
    public class CourseService : ICourseService
    {
        private static List<Course> courses = new()
        {
            new Course { Id = 1, Title = "C#", Credits = 4, Duration = 45 },
            new Course { Id = 2, Title = "ASP.NET Core", Credits = 5, Duration = 60 }
        };

        public List<Course> GetCourses() => courses;

        public Course GetCourse(int id)
        {
            return courses.FirstOrDefault(c => c.Id == id);
        }

        public void AddCourse(Course course)
        {
            courses.Add(course);
        }

        public void UpdateCourse(int id, Course course)
        {
            var data = courses.FirstOrDefault(c => c.Id == id);

            if (data != null)
            {
                data.Title = course.Title;
                data.Credits = course.Credits;
                data.Duration = course.Duration;
            }
        }

        public void DeleteCourse(int id)
        {
            var data = courses.FirstOrDefault(c => c.Id == id);

            if (data != null)
            {
                courses.Remove(data);
            }
        }
    }
}