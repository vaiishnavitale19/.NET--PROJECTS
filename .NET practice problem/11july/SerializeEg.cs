// Serialization converts an object into a format (JSON) so it can be saved or transferred.

using System;
using System.Text.Json;

class SerializeEg
{
    static void Main()
    {
        Employee e = new Employee(101, "abc", 4500);

        string json = JsonSerializer.Serialize(e);
        Console.WriteLine(json);

        // {101, abc, 4500}

        // Deserialize
        Employee e1 = JsonSerializer.Deserialize<Employee>(json);

        Console.WriteLine(e1.EmpName);
    }
}