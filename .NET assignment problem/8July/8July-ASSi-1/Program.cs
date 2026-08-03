using System;

class Program
{
    static void Main(string[] args)
    {
        int[] sales = { 400, 600, 300, 533 };

        int total = 0;
        int highest = sales[0];
        int lowest = sales[0];

        Console.WriteLine("sales :");
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

        Console.WriteLine("total :" + total);
        Console.WriteLine("highest :" + highest);
        Console.WriteLine("lowest :" + lowest);
              Console.WriteLine("average:" + average);
    }
}