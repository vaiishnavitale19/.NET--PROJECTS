using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace _6Aug.Models
{
    public class Product
    {
        public int Id { get; set; } //primary key

        [Required(ErrorMessage = "Product name is mandatory")]
        [StringLength(60, ErrorMessage = "Product name can be max 60 letters")]
        public string PName { get; set; }

        [Required(ErrorMessage = "Product price is mandatory")]
        [Range(15, 1000000, ErrorMessage = "Product price cannot be less than 15 & more than 1000000")]
        [Precision(18, 2)]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Product quantity is mandatory")]
        [Range(1, 100, ErrorMessage = "Product Quantity cannot be less than 1 & more than 100")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Product stock available is mandatory")]
        [StringLength(3, ErrorMessage = "Product stock can be max of 3 letters")]
        public string Availability { get; set; }
    }
}
