using System;
using System.Collections.Generic;

class Collection
{
    static void Main()
    {
        // Create a list of string
        List<string> names = new List<string>();

        // Add items
       
        names.Add("Achal");
        
        names.Add("Vaishnavi");
       

        // Display all items
        foreach (string f in names)
        {
            Console.WriteLine(f);
        }
    }
}