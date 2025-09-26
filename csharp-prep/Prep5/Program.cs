using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        DisplayResult();
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string AskName()
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        return name;
    }

    static int UserNumber()
    {
        Console.Write("Enter your favorite number ");
        string numberStr = Console.ReadLine();
        int numberInt = int.Parse(numberStr);
        return numberInt;
    }

    static void UserYear(out int trueYear)
    {
        Console.Write("What is your birth year? ");
        string userYear = Console.ReadLine();
        trueYear = int.Parse(userYear);
    }

    static int SquareNumber()
    {
        Console.Write("Enter a number to square: ");
        string userSingleInput = Console.ReadLine();
        int trueSingleInput = int.Parse(userSingleInput);
        int trueSquared = trueSingleInput * trueSingleInput;
        return trueSquared;
    }

    static void DisplayResult()
    {
        DisplayWelcome();

        string name = AskName();

        int favoriteNumber = UserNumber();

        int squaredNumber = SquareNumber();

        int birthYear;
        UserYear(out birthYear);

        int age = 2025 - birthYear;

        Console.WriteLine($"{name}, the square of your number is {squaredNumber}.");
        Console.WriteLine($"{name}, you will turn {age} this year.");
        
    }


}