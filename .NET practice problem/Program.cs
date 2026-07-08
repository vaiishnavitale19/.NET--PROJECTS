using System;

class Student
{
    public string name;
    public string institute;
    public long dob;
    public string branch;
    public int rollno;
    public char gender;
    public float height;

    public void Display()
    {
        Console.WriteLine("Name : " + name);
        Console.WriteLine("Institute : " + institute);
        Console.WriteLine("DOB : " + dob);
        Console.WriteLine("Branch : " + branch);
        Console.WriteLine("Roll No : " + rollno);
        Console.WriteLine("Gender : " + gender);
        Console.WriteLine("Height : " + height);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create Object
        Student s1 = new Student();

        // Assign Values
        s1.name = "Vaishnavi";
        s1.institute = "SSGMCE";
        s1.dob = 399432;
        s1.branch = "CSE";
        s1.rollno = 28;
        s1.gender = 'F';
        s1.height = 5.5f;

        // Call Method
        s1.Display();
    }
}