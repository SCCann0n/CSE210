using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {

        string userResponse = "0";

        Reference reference1 = new Reference("John", 3, 16);

        Scripture scripture1 = new Scripture(reference1, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        
        Console.Clear();

        scripture1.Display();

        while (userResponse.ToLower() !=  "quit" && !scripture1.IsDone())
        {
            Console.WriteLine("\nPress enter to continue; type 'quit' to finish. ");
            userResponse = Console.ReadLine();

            if (userResponse == "")
            {
                //clear the console
                Console.Clear();

                //Redisplay scripture with missing character
                scripture1.HideWords();

                scripture1.Display();
                //redisplay the scripture with words missing

                if (scripture1.IsDone())
                {
                    Console.WriteLine("All words are hidden. Restart the program.");
                    userResponse = "quit";
                }
            }
        }
    }
}