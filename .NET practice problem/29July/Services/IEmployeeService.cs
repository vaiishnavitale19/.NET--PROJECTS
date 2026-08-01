using _29July.Models;

namespace _29July.Services
{
    public interface IEmployeeService
    {
        List<Employee> GetEmployees();

        Employee? GetEmployee(int deptId);

        Employee? GetEmployeeName(string name);

        Employee AddEmployee(Employee employee);
    }
}