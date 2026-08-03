using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        List<string> books = new List<string>();
        books.Add("addg");
        books.Add("grjktri");
Console.WriteLine("avabile book");
        foreach (String book in books)
        {
            Console.WriteLine(book);
        }
        books.Add("eetdf");
        books.Remove("addg");
         Console.WriteLine(" undate book");
        foreach (String book in books)
        {
            Console.WriteLine(book);
        }
         Console.WriteLine("total books:" +books.Count);
    }
}