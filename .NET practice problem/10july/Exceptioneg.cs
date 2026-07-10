//exception handling prevents a program crashing when error occurs
//try - risky code
//catch(Exception e) - handle exception
//finally - always executes

using System;

class Exceptioneg
{
    static void Main()
    {
        try
        {
            int a = 50;
            int b = 5;
            int c = a / b;
            Console.WriteLine(c);
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}