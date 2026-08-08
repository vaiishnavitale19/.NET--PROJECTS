namespace _7Aug.Models
{
    public class OrderItems
    {
        public int Id { get; set; }

        //foreign key referencing product table
        public int ProductId { get; set; }

        //allows access to product details
        public Product? product { get; set; }

        //foreign key referencing Order table
        public int OrderId { get; set; }

        //allows access to order details
        public Orders? Order { get; set; }

        //number of units ordered
        public int Quantity { get; set; }
    }
}
