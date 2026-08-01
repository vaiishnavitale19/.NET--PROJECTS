using _30July_assignment.Models;

namespace _30July_assignment.Services
{
    
        public class DepartmentService : IDepartmentService
        {
            private static List<Department> departments = new List<Department>
        {
            new Department
            {
                DepartmentId = 1,
                DepartmentName = "HR",
                DepartmentCode = "HR01",
                Status = "Active"
            },

            new Department
            {
                DepartmentId = 2,
                DepartmentName = "IT",
                DepartmentCode = "IT01",
                Status = "Active"
            },

            new Department
            {
                DepartmentId = 3,
                DepartmentName = "Finance",
                DepartmentCode = "FIN01",
                Status = "Active"
            }
        };

            public List<Department> GetAll()
            {
                return departments;
            }

            public Department GetById(int id)
            {
                return departments.FirstOrDefault(x => x.DepartmentId == id);
            }

            public Department Add(Department department)
            {
                department.DepartmentId =
                    departments.Count == 0
                    ? 1
                    : departments.Max(x => x.DepartmentId) + 1;

                departments.Add(department);

                return department;
            }

            public bool Update(int id, Department department)
            {
                var existing = departments.FirstOrDefault(x => x.DepartmentId == id);

                if (existing == null)
                    return false;

                existing.DepartmentName = department.DepartmentName;
                existing.DepartmentCode = department.DepartmentCode;
                existing.Status = department.Status;

                return true;
            }

            public bool Delete(int id)
            {
                var department = departments.FirstOrDefault(x => x.DepartmentId == id);

                if (department == null)
                    return false;

                departments.Remove(department);

                return true;
            }
        }
}
