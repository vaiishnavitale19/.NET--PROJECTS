using System;

class Program8july1
{
    static void Main(string[] args)
    {
     
        int[] sales = { 215000, 330000, 18000, 40000, 35000, 28000 };

        int total = 0;
        int highest = sales[0];
        int lowest = sales[0];

        Console.WriteLine("Monthly Sales:");

        
        foreach (int s in sales)
        {
            Console.WriteLine(s);
            total = total + s;

            if (s > highest)
                highest = s;

            if (s < lowest)
                lowest = s;
        }

        
        double average = (double)total / sales.Length;

        Console.WriteLine();
        Console.WriteLine("Total Sales : " + total);
        Console.WriteLine("Average Sales : " + average);
        Console.WriteLine("Highest Sales : " + highest);
        Console.WriteLine("Lowest Sales : " + lowest);
    }
}