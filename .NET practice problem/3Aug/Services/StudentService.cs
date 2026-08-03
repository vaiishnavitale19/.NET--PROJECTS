
using global::_3Aug.Models;
    using global::_3Aug.Repository;
    using System.Xml.Linq;

    namespace _3Aug.Services
    {
        public class StudentService : IStudentService
        {
            private static List<Student> students = new()
        {
            new Student { Id = 1, Name = "John", Age = 20, Course = "DotNet", Email = "john@gmail.com" },
            new Student { Id = 2, Name = "Bob", Age = 19, Course = "DotNet", Email = "bob@gmail.com" },
            new Student { Id = 3, Name = "David", Age = 24, Course = "Java", Email = "DV@gmail.com" }
        };

            public void AddStudent(Student student)
            {
                students.Add(student);
            }

            public void DeleteStudent(int id)
            {
                var existing = GetStudent(id);

                if (existing == null)
                    throw new Exception("Student not found");

                students.Remove(existing);
            }

            public List<Student> GetAll()
            {
                return students;
            }

            public Student? GetStudent(int id)
            {
                return students.FirstOrDefault(s => s.Id == id);
            }

            public void UpdateStudent(Student student)
            {
                var existing = GetStudent(student.Id);

                if (existing == null)
                    throw new Exception("Student not found");

                existing.Age = student.Age;
            }
        }
    }


