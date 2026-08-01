using _30July_assignment.Models;

namespace _30July_assignment.Services
{
    public class EmployeeService : IEmployeeService
    {
        private static List<Employee> employees = new List<Employee>
        {
            new Employee
            {
                EmployeeId = 1,
                FirstName = "Rahul",
                LastName = "Patil",
                Email = "rahul@gmail.com",
                MobileNumber = "9876543210",
                DateOfBirth = new DateTime(1998, 5, 10),
                Gender = "Male",
                Salary = 45000,
                DateOfJoining = new DateTime(2023, 6, 1),
                DepartmentId = 2,
                Designation = "Developer",
                EmploymentStatus = "Active"
            },

            new Employee
            {
                EmployeeId = 2,
                FirstName = "Priya",
                LastName = "Sharma",
                Email = "priya@gmail.com",
                MobileNumber = "9876543211",
                DateOfBirth = new DateTime(1997, 8, 15),
                Gender = "Female",
                Salary = 40000,
                DateOfJoining = new DateTime(2022, 4, 10),
                DepartmentId = 1,
                Designation = "HR Executive",
                EmploymentStatus = "Active"
            }
        };

        public List<Employee> GetAll()
        {
            return employees;
        }

        public Employee GetById(int id)
        {
            return employees.FirstOrDefault(x => x.EmployeeId == id);
        }

        public Employee Add(Employee employee)
        {
            employee.EmployeeId =
                employees.Count == 0
                ? 1
                : employees.Max(x => x.EmployeeId) + 1;

            employees.Add(employee);

            return employee;
        }

        public bool Update(int id, Employee employee)
        {
            var existing = employees.FirstOrDefault(x => x.EmployeeId == id);

            if (existing == null)
                return false;

            existing.FirstName = employee.FirstName;
            existing.LastName = employee.LastName;
            existing.Email = employee.Email;
            existing.MobileNumber = employee.MobileNumber;
            existing.DateOfBirth = employee.DateOfBirth;
            existing.Gender = employee.Gender;
            existing.Salary = employee.Salary;
            existing.DateOfJoining = employee.DateOfJoining;
            existing.DepartmentId = employee.DepartmentId;
            existing.Designation = employee.Designation;
            existing.EmploymentStatus = employee.EmploymentStatus;

            return true;
        }

        public bool Delete(int id)
        {
            var employee = employees.FirstOrDefault(x => x.EmployeeId == id);

            if (employee == null)
                return false;

            employees.Remove(employee);

            return true;
        }

        public List<Employee> Search(
            string name,
            string department,
            string email,
            int? employeeId,
            string status)
        {
            var result = employees.AsQueryable();

            if (!string.IsNullOrEmpty(name))
            {
                result = result.Where(x =>
                    (x.FirstName + " " + x.LastName)
                    .Contains(name, StringComparison.OrdinalIgnoreCase));
            }

            if (!string.IsNullOrEmpty(email))
            {
                result = result.Where(x =>
                    x.Email.Contains(email, StringComparison.OrdinalIgnoreCase));
            }

            if (employeeId.HasValue)
            {
                result = result.Where(x => x.EmployeeId == employeeId);
            }

            if (!string.IsNullOrEmpty(status))
            {
                result = result.Where(x =>
                    x.EmploymentStatus.Equals(
                        status,
                        StringComparison.OrdinalIgnoreCase));
            }

            return result.ToList();
        }

        public List<Employee> GetByDepartment(int departmentId)
        {
            return employees
                .Where(x => x.DepartmentId == departmentId)
                .ToList();
        }
    }
}
