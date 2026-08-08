using System.ComponentModel.DataAnnotations;

namespace _7Aug.Models
{
    public class Product
    {
        //primary key
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Range(15, 1000000)]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Range(0, 1000)]
        public int Stock { get; set; }

        //one product can appear in many order items
        //EF use this property to load related orderitems records
        public ICollection<OrderItems>? OrderItems { get; set; }
    }
}
