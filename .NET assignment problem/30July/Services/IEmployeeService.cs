using _30July_assignment.Models;

namespace _30July_assignment.Services
{
    public interface IEmployeeService
    {
        List<Employee> GetAll();
        Employee GetById(int id);
        Employee Add(Employee employee);
        bool Update(int id, Employee employee);
        bool Delete(int id);
        List<Employee> Search(string name, string department, string email, int? employeeId, string status);
        List<Employee> GetByDepartment(int departmentId);
    }
}
