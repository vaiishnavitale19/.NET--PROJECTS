using System.ComponentModel.DataAnnotations;

namespace _22Jul2026.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is Mandatory")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Price is Mandatory")]
        [Range(10, 100000, ErrorMessage = "Price must be between 10 and 100000")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Category is Mandatory")]
        public string Category { get; set; } = string.Empty;

        [Required(ErrorMessage = "Stock is Mandatory")]
        [Range(1, 10000, ErrorMessage = "Stock must be greater than 0")]
        public int Stock { get; set; }
    }
}