using _30July_assignment.Models;

namespace _30July_assignment.Services
{
    public interface IDepartmentService
    {

        List<Department> GetAll();
        Department GetById(int id);
        Department Add(Department department);
        bool Update(int id, Department department);
        bool Delete(int id);

    }
}
