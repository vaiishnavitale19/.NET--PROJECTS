using System.ComponentModel.DataAnnotations;

namespace AutomobileManagementSystem.Models
{
    public class Manufacturer
    {
        [Required]
        [StringLength(50)]
        public string ManufacturerName { get; set; } = string.Empty;

        [Required]
        public string Country { get; set; } = string.Empty;

        [Required]
        [RegularExpression(@"^[0-9]{10}$",
            ErrorMessage = "Enter a valid 10-digit contact number")]
        public string ContactNumber { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; } = string.Empty;
    }
}