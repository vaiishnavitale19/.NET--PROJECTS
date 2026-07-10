using System;

// Delegate - type that holds a reference to a method
// Similar to function pointer
// Func - returns a value

delegate void MessageDelegate(string msg);

class Delegateeg
{
    static void Display(string message)
    {
        Console.WriteLine(message);
    }

    static void Main()
    {
        // Built-in delegate Func
        Func<int, int, int> add = (a, b) => a + b;
        Console.WriteLine(add(588, 756));

        // Custom delegate
        MessageDelegate m = Display;
        m("Hello, I am learning .NET C#");

        Button bt = new Button();
        bt.click += () => Console.WriteLine("Click event");
        bt.Press();
    }
}