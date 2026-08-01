using _29July.Models;

namespace _29July.Services
{
    public class EmployeeService : IEmployeeService
    {
        private static List<Employee> employees = new List<Employee>()
        {
            new Employee
            {
                Id = 101,
                Name = "Vira",
                PhoneN = 2324353,
                Email = "nferhb@gmail.com",
                DeptId = 23
            },

            new Employee
            {
                Id = 102,
                Name = "Riva",
                PhoneN = 23244353,
                Email = "nfedsgb@gmail.com",
                DeptId = 245
            },

            new Employee
            {
                Id = 103,
                Name = "Piya",
                PhoneN = 2324353632,
                Email = "nfpiyahb@gmail.com",
                DeptId = 76
            },

            new Employee
            {
                Id = 104,
                Name = "Siya",
                PhoneN = 6424353,
                Email = "rhb@gmail.com",
                DeptId = 23
            }
        };

        public List<Employee> GetEmployees()
        {
            return employees;
        }

        public Employee? GetEmployee(int deptId)
        {
            return employees.FirstOrDefault(e => e.DeptId == deptId);
        }

        public Employee? GetEmployeeName(string name)
        {
            return employees.FirstOrDefault(e =>
                e.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        public Employee AddEmployee(Employee employee)
        {
            employees.Add(employee);
            return employee;
        }
    }
}