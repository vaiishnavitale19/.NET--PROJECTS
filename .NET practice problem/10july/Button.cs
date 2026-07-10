//Events - based on delegate & used to notify other classes when something happens

using System;

class Button
{
    public event Action click;

    public void Press()
    {
        Console.WriteLine("Button is pressed");
        click?.Invoke();
    }
}