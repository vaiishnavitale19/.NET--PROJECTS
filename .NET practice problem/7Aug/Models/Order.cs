using System.ComponentModel.DataAnnotations;

namespace _7Aug.Models
{
    public class Orders
    {
        //primary key
        public int Id { get; set; }

        [Required(ErrorMessage = "Customer Name is required")]
        public string CustomerName { get; set; }

        //stores order creation date, default to current date & time
        public DateTime OrderDate { get; set; } = DateTime.Now;

        //one order can contain multiple order items
        public ICollection<OrderItems> OrderItems { get; set; }
    }
}
