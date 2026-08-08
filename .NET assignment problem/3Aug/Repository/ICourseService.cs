using _3Aug.Models;

namespace _3Aug.Repository
{
    public interface ICourseService
    {
        void AddCourse(Course course);

        void DeleteCourse(int id);

        List<Course> GetAll();

        Course? GetCourse(int id);

        void UpdateCourse(Course course);
    }
}
