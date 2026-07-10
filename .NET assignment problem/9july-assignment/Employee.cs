using System;

abstract class Employee
{
    public int EmployeeId;
    public string Name;
    public string Department;
    public int LeaveBalance;

    public abstract void SetLeaveBalance();

    public void DisplayDetails()
    {
        Console.WriteLine(EmployeeId + " " + Name + " " + Department + " " + LeaveBalance);
    }
}