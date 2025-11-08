using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        bool running = true;
        while (running)
        {   
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("\nEnter your choice: ");
            
            
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":

                    BreathingActivity bActivity = new BreathingActivity();
                    bActivity.DoStartingMessage();
                    bActivity.DoActivity();
                    bActivity.DoEndingMessage();
                    break;

                case "2":
                    ReflectionActivity rActivity = new ReflectionActivity();
                    rActivity.DoStartingMessage();
                    rActivity.DoActivity();
                    rActivity.DoEndingMessage();
                    break;
                
                case "3":
                    ListingActivity lActivity = new ListingActivity();
                    lActivity.DoStartingMessage();
                    lActivity.DoActivity();
                    lActivity.DoEndingMessage();
                    break;

                case "4":
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}