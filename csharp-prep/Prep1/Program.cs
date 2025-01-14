using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade? ");
        string response = Console.ReadLine();
        int gradePercent = int.Parse(response);

        string letter = "";

        if (gradePercent < 60)
        {
            letter = "F";
        }
        if (gradePercent >= 60 && gradePercent < 70)
        {
            letter = "D";
        }
        if (gradePercent >= 70 && gradePercent < 80)
        {
            letter = "C";
        }
        if (gradePercent >= 80 && gradePercent < 90)
        {
            letter = "B";
        }
        if (gradePercent >= 90)
        {
            letter = "A";
        }

        Console.WriteLine($"Your letter grade is {letter}!");

        if (gradePercent >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("You'll get it next time!");
        }
    }
}

// Console.Write("What is your first name? ");
// string FirstName = Console.ReadLine();

// Console.Write("What is your last name? ");
// string LastName = Console.ReadLine();

// Console.WriteLine($"Your name is {LastName}, {FirstName} {LastName}. ");