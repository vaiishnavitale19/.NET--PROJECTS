using System;
using System.Collections.Generic;

class Program8july2

{
    static void Main(string[] args)
    {
        List<string> books = new List<string>();

        books.Add("Harry Potter");
        books.Add("The Hobbit");
        books.Add("Atomic Habits");
        books.Add("The Alchemist");

        Console.WriteLine("Available Books:");
        foreach (string book in books)
        {
            Console.WriteLine(book);
        }

        books.Add("Rich Dad Poor Dad");
        books.Remove("The Hobbit");

        Console.WriteLine("\nUpdated Book List:");
        foreach (string book in books)
        {
            Console.WriteLine(book);
        }

        Console.WriteLine("\nTotal Books: " + books.Count);
    }
}