using _3Aug.Models;
using _3Aug.Repository;

namespace _3Aug.Services
{
    public class CourseService : ICourseService
    {
        private static List<Course> courses = new List<Course>
        {
            new Course
            {
                Id = 1,
                Name = "DotNet",
                Duration = "6 Months",
                Fees = 25000
            },

            new Course
            {
                Id = 2,
                Name = "Java",
                Duration = "6 Months",
                Fees = 22000
            },

            new Course
            {
                Id = 3,
                Name = "Python",
                Duration = "4 Months",
                Fees = 18000
            }
        };

        // Add Course
        public void AddCourse(Course course)
        {
            courses.Add(course);
        }

        // Delete Course
        public void DeleteCourse(int id)
        {
            var existing = GetCourse(id);

            if (existing == null)
            {
                throw new Exception("Course not found");
            }

            courses.Remove(existing);
        }

        // Get All Courses
        public List<Course> GetAll()
        {
            return courses;
        }

        // Get Course By Id
        public Course? GetCourse(int id)
        {
            return courses.FirstOrDefault(c => c.Id == id);
        }

        // Update Course
        public void UpdateCourse(Course course)
        {
            var existing = GetCourse(course.Id);

            if (existing == null)
            {
                throw new Exception("Course not found");
            }

            existing.Name = course.Name;
            existing.Duration = course.Duration;
            existing.Fees = course.Fees;
        }
    }
}