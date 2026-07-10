using System;

class OOP
{
    static void Main()
    {
        // Encapsulation
        Employee e = new Employee();

        e.empName = "Vaishnavi";
        e.salary = 100000;

        Console.WriteLine(e.empName + " " + e.salary);

        // Compile Time Polymorphism
        CompiletimePoly c = new CompiletimePoly();
        c.Search(123);

        Console.WriteLine();

        // Runtime Polymorphism
        RuntimePoly r = new RuntimePoly();

        r.Checkout(new UpiPayment(), 500);
        r.Checkout(new CreditPayment(), 55000);
        r.Checkout(new NetBanking(), 25000);

        Console.WriteLine();

        // Abstraction
        FileStorage s = new Abstracteg();
        s.Upload("CV.pdf");
        s.ValidateFile();
    }
}