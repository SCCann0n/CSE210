using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public class Activity
{
    protected string _name;

    protected string _description;

    protected int _duration;

    public Activity(string name, string description)
    {
        this._name = name;

        this._description = description;
    }

    public void DoStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine($"{_description}");
        Console.Write("How long would you like for the session? ");
        string userTime = Console.ReadLine();
        _duration = int.Parse(userTime);

        Console.Clear();

        Console.Write("Get ready...");
        _SpinnerAnimation(3);

    }

    public void DoEndingMessage()
    {
        Console.WriteLine($"Well Done!\n You have completed another {_duration} seconds of the {_name}");

        _SpinnerAnimation(3);
    }

    protected void _SpinnerAnimation(int setTime)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(setTime);

        while (futureTime >= DateTime.Now)
        {
            Console.Write("+");

            Thread.Sleep(500);

            Console.Write("\b \b"); // Erase the + character
            
            Console.Write("-"); // Replace it with the - character

            Thread.Sleep(500);

            Console.Write("\b \b");

        }


    }

    protected void _Countdown(int countFrom)
    {
        while (countFrom >= 0)
        {
            Console.Write(countFrom);

            Thread.Sleep(1000);

            Console.Write("\b"); // Erase the + character

            countFrom--;
        }

    }
}