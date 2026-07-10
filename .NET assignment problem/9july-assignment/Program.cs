using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>();

        PermanentEmployee p1 = new PermanentEmployee();
        p1.EmployeeId = 101;
        p1.Name = "Ram";
        p1.Department = "cs";
        p1.SetLeaveBalance();

        ContractEmployee c1 = new ContractEmployee();
        c1.EmployeeId = 103;
        c1.Name = "Aman";
        c1.Department = "HR";
        c1.SetLeaveBalance();

        employees.Add(p1);
        employees.Add(c1);

        Console.WriteLine("All Employees");
        foreach (Employee e in employees)
        {
            e.DisplayDetails();
        }

        List<LeaveRequest> leaves = new List<LeaveRequest>();

        LeaveRequest l1 = new LeaveRequest();
        l1.LeaveId = 1;
        l1.EmployeeId = 101;
        l1.NumberOfDays = 2;
        l1.Reason = "Medical";

        leaves.Add(l1);

        Console.WriteLine("Leave Requests");
        foreach (LeaveRequest l in leaves)
        {
            l.DisplayLeave();
        }

        Console.WriteLine("Permanent Employees");
        foreach (Employee e in employees)
        {
            if (e is PermanentEmployee)
            {
                e.DisplayDetails();
            }
        }

        Console.WriteLine("Employee Id 103");
        foreach (Employee e in employees)
        {
            if (e.EmployeeId == 103)
            {
                e.DisplayDetails();
            }
        }

        Console.WriteLine("Total Employees = " + employees.Count);
        Console.WriteLine("Total Leave Requests = " + leaves.Count);
    }
}