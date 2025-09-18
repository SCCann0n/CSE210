using System;

class Program
{
    static void Main(string[] args)
    {

        // Console.Write("What is your first name? ");
        // string firstName = Console.ReadLine();
        // Console.Write("What is your last name? ");
        // string lastName = Console.ReadLine();

        // Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}. ");

        Console.Write("What is your Grade Percentage? ");
        string userGrade = Console.ReadLine();
        int trueGrade = int.Parse(userGrade);

        string letterGrade = "A";

        if (trueGrade > 90)
        {
            letterGrade = "A";
        }

        else if (trueGrade > 80)
        {
            letterGrade = "B";
        }

        else if (trueGrade > 70)
        {
            letterGrade = "C";
        }

        else
        {
            letterGrade = "F";
        }
        

        Console.WriteLine($"Your letter grade is {letterGrade}.");

        // Console.WriteLine("Hello Sandbox World!");
        // //Console.WriteLine is like print in python, or prinf in C
        // //Dont use single quotes for writeline
        // //C# Uses camelCase or PascalCase

        // string firstName = "Seth";

        // Console.WriteLine("Hello " + firstName);
        // Console.WriteLine($"Hello {firstName}");
        // Console.Write($"Hello Bob");
        // Console.Write("\nThis is another line\n");

        // //Console.WriteLine adds a new line, while Console.Write doesn't

        // Console.Write("What is your favorite color? ");
        // string favoriteColor = Console.ReadLine();

        // Console.WriteLine($"{firstName}, your favorite color is {favoriteColor}.");

        // //We get user input in C# From Console.ReadLine

        // Console.Write("How old are you? ");
        // int age = int.Parse(Console.ReadLine());
        // Console.WriteLine($"{firstName}, you are {age} years old");

        // double x = 1.5;
        // float y = 1.5f;

        // bool isDone = false;

        // if (isDone)
        // {
        //     Console.WriteLine("All done.");
        // }
        // else
        // {
        //     Console.WriteLine("Not done yet.");
        // }

    }
}