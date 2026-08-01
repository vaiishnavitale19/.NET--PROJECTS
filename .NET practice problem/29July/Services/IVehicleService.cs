using _29July.Models;

namespace _29July.Services
{
    public interface IVehicleService
    {
        List<Vehicle> GetVehicles();
        Vehicle? GetVehicle(int id);
        Vehicle AddVehicle(Vehicle vehicle);
    }
}
