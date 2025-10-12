namespace myJournal;
using System;

class Program
{
    static void Main(string[] args)
    {
        Journal userJournal = new Journal();

        Prompt _userPrompt = new Prompt();

        int indexLoop = -1;
        
        while (indexLoop != 5)
        {
            Console.WriteLine("\n1. New entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save to file");
            Console.WriteLine("4. Load from file");
            Console.WriteLine("5. Quit");
            Console.WriteLine("Select an option: ");
            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                string prompt = _userPrompt.GetPrompt();
                Console.WriteLine("\nPrompt: " + prompt);

                Console.WriteLine("Your response: ");
                string userText = Console.ReadLine();

                Entry entry = new Entry();
                entry._prompt = prompt;
                entry._text = userText;
                entry._date = DateTime.Now;

                userJournal._userEntry.Add(entry);

                Console.WriteLine("Entry added. ");
            }

            if (userInput == "2")
            {
                Console.WriteLine("\nJournal Entries: ");
                userJournal.DisplayJournal();
            }

            if (userInput == "3")
            {
                Console.Write("What file would you like to save?: ");
                string filename = Console.ReadLine();
                userJournal.Savetofile(filename);
            }

            if (userInput == "4")
            {
                Console.Write("What file would you like to load?: ");
                string filename = Console.ReadLine();
                userJournal.LoadFromFile(filename);
            }

            if (userInput == "5")
            {
                indexLoop = 5;
                Console.WriteLine("Goodbye!");
            }
        }
    }
}