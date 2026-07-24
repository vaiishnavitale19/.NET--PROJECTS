using System.ComponentModel.DataAnnotations;

namespace AutomobileManagementSystem.Models
{
    public class Automobile
    {
        [Required]
        public int VehicleId { get; set; }

        [Required(ErrorMessage = "Vehicle Name is required")]
        [StringLength(50)]
        public string VehicleName { get; set; } = string.Empty;

        [Required]
        [StringLength(30)]
        public string Brand { get; set; } = string.Empty;

        [Required]
        [Range(2000, 2035)]
        public int ModelYear { get; set; }

        [Required]
        [Range(10000, 10000000)]
        public decimal Price { get; set; }

        [Required]
        [RegularExpression("Petrol|Diesel|Electric|CNG",
            ErrorMessage = "Fuel Type must be Petrol, Diesel, Electric or CNG")]
        public string FuelType { get; set; } = string.Empty;
    }
}