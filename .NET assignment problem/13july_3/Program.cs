using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose Payment");
        Console.WriteLine("1. UPI");
        Console.WriteLine("2. Credit Card");
        Console.WriteLine("3. Debit Card");
        Console.WriteLine("4. Cash on Delivery");

        Console.Write("Enter your choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("UPI Payment Successful");
                break;

            case 2:
                Console.WriteLine("Credit Card Payment Successful");
                break;

            case 3:
                Console.WriteLine("Debit Card Payment Successful");
                break;

            case 4:
                Console.WriteLine("Cash on Delivery Selected");
                Console.WriteLine("Order Placed Successfully");
                break;

            default:
                Console.WriteLine("Invalid Option");
                break;
        }
    }
}