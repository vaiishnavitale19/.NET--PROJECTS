using _29July.Models;

namespace _29July.Services
{
    public class VehicleService : IVehicleService
    {
        private static List<Vehicle> vehicles = new List<Vehicle>()
        {
            new Vehicle
            {
                Id = 1,
                VehicleName = "Swift",
                Brand = "Maruti",
                Price = 650000
            },

            new Vehicle
            {
                Id = 2,
                VehicleName = "Creta",
                Brand = "Hyundai",
                Price = 1200000
            },

            new Vehicle
            {
                Id = 3,
                VehicleName = "Nexon",
                Brand = "Tata",
                Price = 950000
            }
        };

        public List<Vehicle> GetVehicles()
        {
            return vehicles;
        }

        public Vehicle? GetVehicle(int id)
        {
            return vehicles.FirstOrDefault(v => v.Id == id);
        }

        public Vehicle AddVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
            return vehicle;
        }
    }
}
