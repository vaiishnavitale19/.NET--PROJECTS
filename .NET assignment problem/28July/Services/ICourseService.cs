using _28July_Assignment.Models;

namespace _28July_Assignment.Services
{
    public interface ICourseService
    {
        List<Course> GetCourses();
        Course GetCourse(int id);
        void AddCourse(Course course);
        void UpdateCourse(int id, Course course);
        void DeleteCourse(int id);
    }
}