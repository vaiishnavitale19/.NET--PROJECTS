//LINQ - Language Integrated Query
//used to query collections like arrays, list
//where(): filter data, select(), orderBy(), orderByDescending()
//first(), count(), min(), max(),sum()

using System;
using System.Linq;

class Lineqg
{
    static void Main()
    {
        int[] numberss = {8,7,6,4,1,8,7,8,3,9};
        var even = numberss.Where(x => x % 2 == 0);

        foreach(var n in even)
        {
            Console.WriteLine(n);
        }
    }
}