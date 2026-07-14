using System;

class FeeCalculator
{
    public static double CalculateFee(Student student)
    {
        int credits = student.GetTotalCredits();

        if (student.StudentType.Equals("Regular", StringComparison.OrdinalIgnoreCase))
        {
            return credits * 1000;
        }
        else if (student.StudentType.Equals("Scholarship", StringComparison.OrdinalIgnoreCase))
        {
            return credits * 500;
        }
        else if (student.StudentType.Equals("Part-Time", StringComparison.OrdinalIgnoreCase))
        {
            return credits * 800;
        }

        return 0;
    }
}