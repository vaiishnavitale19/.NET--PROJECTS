using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Product> products = new List<Product>();
        List<CartItem> cart = new List<CartItem>();

        Console.Write("How many products do you want to add: ");
        int n = Convert.ToInt32(Console.ReadLine());

        // Add Products
        for (int i = 0; i < n; i++)
        {
            Product p = new Product();

            Console.WriteLine("\nEnter Product " + (i + 1));

            Console.Write("Product ID: ");
            p.ProductId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Product Name: ");
            p.ProductName = Console.ReadLine();

            Console.Write("Price: ");
            p.Price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Stock: ");
            p.Stock = Convert.ToInt32(Console.ReadLine());

            products.Add(p);
        }

        // Display Products
        Console.WriteLine("\n------ Product List ------");

        foreach (Product p in products)
        {
            Console.WriteLine($"{p.ProductId}  {p.ProductName}  {p.Price}  {p.Stock}");
        }

        // Search Product
        Console.Write("\nEnter Product Name to Search: ");
        string search = Console.ReadLine();

        Product found = products.Find(x => x.ProductName.Equals(search, StringComparison.OrdinalIgnoreCase));

        if (found != null)
        {
            Console.WriteLine("\nProduct Found");
            Console.WriteLine("Product ID : " + found.ProductId);
            Console.WriteLine("Product Name : " + found.ProductName);
            Console.WriteLine("Price : " + found.Price);
            Console.WriteLine("Stock : " + found.Stock);
        }
        else
        {
            Console.WriteLine("Product Not Found");
        }

        // Add to Cart
        int choice;

        do
        {
            Console.Write("\nEnter Product ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Product product = products.Find(x => x.ProductId == id);

            if (product != null)
            {
                Console.Write("Enter Quantity: ");
                int qty = Convert.ToInt32(Console.ReadLine());

                if (qty <= product.Stock)
                {
                    product.Stock -= qty;

                    cart.Add(new CartItem
                    {
                        ProductName = product.ProductName,
                        Quantity = qty,
                        Price = product.Price
                    });

                    Console.WriteLine("Added to Cart");
                }
                else
                {
                    Console.WriteLine("Stock Not Available");
                }
            }
            else
            {
                Console.WriteLine("Invalid Product ID");
            }

            Console.WriteLine("\n1. Yes");
            Console.WriteLine("2. No");
            Console.Write("Do you want to add another product: ");
            choice = Convert.ToInt32(Console.ReadLine());

        } while (choice == 1);

        // Display Cart
        Console.WriteLine("\n------ CART ------");

        double total = 0;

        foreach (CartItem item in cart)
        {
            Console.WriteLine(item.ProductName + " x" + item.Quantity);

            total += item.Price * item.Quantity;
        }

        // Discount
        double discount = 0;

        if (total >= 10000)
            discount = total * 0.30;
        else if (total >= 5000)
            discount = total * 0.20;
        else if (total >= 1000)
            discount = total * 0.10;

        double finalAmount = total - discount;

        Console.WriteLine("\n------ BILL ------");
        Console.WriteLine("Total Amount : " + total);
        Console.WriteLine("Discount : " + discount);
        Console.WriteLine("Final Amount : " + finalAmount);
    }
}