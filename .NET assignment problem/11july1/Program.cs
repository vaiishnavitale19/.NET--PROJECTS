using System;
using System.Collections.Generic;

class Program
{
    static List<Student> students = new List<Student>();
    static List<Course> courses = new List<Course>();

    static void Main()
    {
        int choice;

        do
        {
            Console.WriteLine("\n===== Student Management System =====");
            Console.WriteLine("1. Student Management");
            Console.WriteLine("2. Course Management");
            Console.WriteLine("3. Register Course");
            Console.WriteLine("4. View Student Details");
            Console.WriteLine("5. Exit");

            Console.Write("Enter Choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    StudentManagement();
                    break;

                case 2:
                    CourseManagement();
                    break;

                case 3:
                    RegisterCourse();
                    break;

                case 4:
                    ViewStudentDetails();
                    break;

                case 5:
                    Console.WriteLine("Thank You...");
                    break;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }

        } while (choice != 5);
    }

    static void StudentManagement()
    {
        Console.WriteLine("\n1. Register Student");
        Console.WriteLine("2. View All Students");
        Console.WriteLine("3. Search Student By ID");

        Console.Write("Enter Choice: ");
        int ch = Convert.ToInt32(Console.ReadLine());

        if (ch == 1)
        {
            Student s = new Student();

            Console.Write("Student ID: ");
            s.StudentId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Student Name: ");
            s.StudentName = Console.ReadLine();

            Console.Write("Department: ");
            s.Department = Console.ReadLine();

            Console.Write("Student Type (Regular/Scholarship/Part-Time): ");
            s.StudentType = Console.ReadLine();

            students.Add(s);

            Console.WriteLine("Student Registered Successfully");
        }
        else if (ch == 2)
        {
            foreach (Student s in students)
            {
                Console.WriteLine(s.StudentId + "  " + s.StudentName + "  " + s.Department);
            }
        }
        else if (ch == 3)
        {
            Console.Write("Enter Student ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Student student = students.Find(x => x.StudentId == id);

            if (student != null)
            {
                Console.WriteLine(student.StudentId);
                Console.WriteLine(student.StudentName);
                Console.WriteLine(student.Department);
                Console.WriteLine(student.StudentType);
            }
            else
            {
                Console.WriteLine("Student Not Found");
            }
        }
    }

    static void CourseManagement()
    {
        Console.WriteLine("\n1. Add Course");
        Console.WriteLine("2. View All Courses");

        Console.Write("Enter Choice: ");
        int ch = Convert.ToInt32(Console.ReadLine());

        if (ch == 1)
        {
            Course c = new Course();

            Console.Write("Course ID: ");
            c.CourseId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Course Name: ");
            c.CourseName = Console.ReadLine();

            Console.Write("Credits: ");
            c.Credits = Convert.ToInt32(Console.ReadLine());

            courses.Add(c);

            Console.WriteLine("Course Added Successfully");
        }
        else if (ch == 2)
        {
            foreach (Course c in courses)
            {
                Console.WriteLine(c.CourseId + "  " + c.CourseName + "  " + c.Credits);
            }
        }
    }
            static void RegisterCourse()
    {
        Console.Write("Enter Student ID: ");
        int sid = Convert.ToInt32(Console.ReadLine());

        Student student = students.Find(x => x.StudentId == sid);

        if (student == null)
        {
            Console.WriteLine("Student Not Found");
            return;
        }

        if (student.EnrolledCourses.Count >= 5)
        {
            Console.WriteLine("Maximum 5 Courses Allowed");
            return;
        }

        Console.Write("Enter Course ID: ");
        int cid = Convert.ToInt32(Console.ReadLine());

        Course course = courses.Find(x => x.CourseId == cid);

        if (course == null)
        {
            Console.WriteLine("Course Not Found");
            return;
        }

        foreach (Course c in student.EnrolledCourses)
        {
            if (c.CourseId == cid)
            {
                Console.WriteLine("Course Already Registered");
                return;
            }
        }

        student.EnrolledCourses.Add(course);

        Console.WriteLine("Course Registered Successfully");
    }

    static void ViewStudentDetails()
    {
        Console.Write("Enter Student ID: ");
        int sid = Convert.ToInt32(Console.ReadLine());

        Student student = students.Find(x => x.StudentId == sid);

        if (student == null)
        {
            Console.WriteLine("Student Not Found");
            return;
        }

        Console.WriteLine("\n===== Student Details =====");
        Console.WriteLine("Student ID : " + student.StudentId);
        Console.WriteLine("Student Name : " + student.StudentName);
        Console.WriteLine("Department : " + student.Department);
        Console.WriteLine("Student Type : " + student.StudentType);

        Console.WriteLine("\nEnrolled Courses");

        if (student.EnrolledCourses.Count == 0)
        {
            Console.WriteLine("No Courses Registered");
        }
        else
        {
            foreach (Course c in student.EnrolledCourses)
            {
                Console.WriteLine(c.CourseId + "  " + c.CourseName + "  " + c.Credits + " Credits");
            }
        }

        Console.WriteLine("\nTotal Credits : " + student.GetTotalCredits());

        double fee = FeeCalculator.CalculateFee(student);

        Console.WriteLine("Total Fee : " + fee);
    }
}