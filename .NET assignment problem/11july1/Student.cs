using System;
using System.Collections.Generic;

class Student
{
    public int StudentId { get; set; }
    public string StudentName { get; set; }
    public string Department { get; set; }
    public string StudentType { get; set; }

    public List<Course> EnrolledCourses { get; set; }

    public Student()
    {
        EnrolledCourses = new List<Course>();
    }

    public int GetTotalCredits()
    {
        int total = 0;

        foreach (Course c in EnrolledCourses)
        {
            total += c.Credits;
        }

        return total;
    }
}