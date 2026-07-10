using System;

class LeaveRequest
{
    public int LeaveId;
    public int EmployeeId;
    public int NumberOfDays;
    public string Reason;

    public void DisplayLeave()
    {
        Console.WriteLine(LeaveId + " " + EmployeeId + " " + NumberOfDays + " " + Reason);
    }
}