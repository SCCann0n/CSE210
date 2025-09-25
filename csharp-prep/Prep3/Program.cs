using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        string magicNumber = Console.ReadLine();
        int trueNumber = int.Parse(magicNumber);

        Console.Write("What is your guess? ");
        string userGuess = Console.ReadLine();
        int trueGuess = int.Parse(userGuess);


        while (trueGuess != trueNumber)
        {
            if (trueGuess > trueNumber)
                Console.WriteLine("Too high ");

            else if (trueGuess < trueNumber)
                Console.WriteLine("Too low ");

            Console.Write("What is your guess? ");
            userGuess = Console.ReadLine();
            trueGuess = int.Parse(userGuess);
        }
        
        Console.WriteLine("That's it! ");
    }
}