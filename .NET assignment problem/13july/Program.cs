using System;

class Program
{
    static void Main(string[] args)
    {
        Customer customer = new Customer();

    
        Console.WriteLine("===== Customer Registration =====");

        Console.Write("Enter Customer ID: ");
        customer.CustomerId = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Name: ");
        customer.Name = Console.ReadLine();

        Console.Write("Enter Email: ");
        customer.Email = Console.ReadLine();

        Console.Write("Enter Password: ");
        customer.Password = Console.ReadLine();

        Console.WriteLine("\nRegistration Successful");

        
        Console.WriteLine("\n===== Customer Login =====");

        bool loginSuccess = false;

        for (int attempt = 1; attempt <= 3; attempt++)
        {
            Console.Write("Enter Email: ");
            string email = Console.ReadLine();

            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            if (email == customer.Email && password == customer.Password)
            {
                Console.WriteLine("\nWelcome " + customer.Name);
                loginSuccess = true;
                break;
            }
            else
            {
                Console.WriteLine("Invalid Email or Password");
                Console.WriteLine("Attempts Left: " + (3 - attempt));
            }
        }

        if (!loginSuccess)
        {
            Console.WriteLine("\nAccount Locked");
        }
    }
}