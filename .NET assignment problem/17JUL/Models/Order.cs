using System;
using System.Collections.Generic;

namespace _17jul_ShopEase.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        public string CustomerName { get; set; }

        public string Address { get; set; }

        public DateTime OrderDate { get; set; }

        public List<CartItem> Items { get; set; } = new();

        public double Total { get; set; }

        public double GST { get; set; }

        public double Discount { get; set; }

        public double GrandTotal { get; set; }

        

    }
}