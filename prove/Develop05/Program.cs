using System;
using System.Text.Json; 
using System.IO;
using System.Collections.Generic;
public class GoalData
{
    public int TotalPoints { get; set; }
    public List<Goal> Goals { get; set; } 
}
class Program
{
     static int _totalPoints = 0;
    static void Main(string[] args)
    {

        List<Goal> goalsList = new List<Goal>();

        Console.Clear();
        bool running = true;
        while (running)
        {

            Console.WriteLine($"You have {_totalPoints} points");
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("\nEnter your choice: ");


            string choice = Console.ReadLine();

            switch (choice)
            {

                case "1":

                    bool running2 = true;
                    while (running2)
                    {
                        Console.WriteLine("The types of goals are");
                        Console.WriteLine("1. Simple Goal");
                        Console.WriteLine("2. Eternal Goal");
                        Console.WriteLine("3. Checklist Goal");
                        Console.WriteLine("4. Exit");
                        Console.WriteLine("Which type of goal would you like to create?");
                        string choice2 = Console.ReadLine();

                        switch (choice2)
                        {
                            case "1":
                                Goal simpleGoal = new SimpleGoal();
                                simpleGoal.CreateGoal();
                                goalsList.Add(simpleGoal);
                                break;

                            case "2":
                                Goal eternalGoal = new EternalGoal();
                                eternalGoal.CreateGoal();
                                goalsList.Add(eternalGoal);
                                break;

                            case "3":
                                Goal checklistGoal = new ChecklistGoal();
                                checklistGoal.CreateGoal();
                                goalsList.Add(checklistGoal);
                                break;

                            case "4":
                                running2 = false;
                                Console.WriteLine("Goodbye!");
                                break;

                            default:
                                Console.WriteLine("Invalid choice. Please try again.");
                                break;
                        }

                    }

                    break;

                case "2":
                    //List
                    ListGoals(goalsList);
                    break;

                case "3":
                    //Save
                    SaveGoal(goalsList);
                    break;

                case "4":
                    //Load
                    LoadGoal(goalsList);
                    break;

                case "5":
                    //Record
                    ListGoals(goalsList);
                    RecordGoal(goalsList);
                    break;

                case "6":
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }


    static void ListGoals(List<Goal> goalsList)
    {
        int i = 1;

        foreach (Goal g in goalsList)
        {
            Console.WriteLine($"{i}. {g.GetGoal()}");
            i++;
        }
    }

    static void RecordGoal(List<Goal> goalsList)
    {
        Console.Write("What goal did you accomplish? ");
        int userRecordNumber = int.Parse(Console.ReadLine());

        userRecordNumber--;

        Goal goalRecord = goalsList[userRecordNumber];

        int earnedPoints = goalRecord.Record();

        _totalPoints += earnedPoints;
    }

    static void SaveGoal(List<Goal> goalsList)
    {
        Console.WriteLine("what is the filename for the goal file? (.json) ");
        string userFileNameSave = Console.ReadLine();

        Console.WriteLine($"You have {_totalPoints} points");

        GoalData dataToSave = new GoalData
        {
            TotalPoints = _totalPoints,

            Goals = goalsList
        };

        string jsonString = JsonSerializer.Serialize(dataToSave);

        File.WriteAllText(userFileNameSave, jsonString);

        Console.WriteLine($"Goals saved to {userFileNameSave}");
    }

    static void LoadGoal(List<Goal> goalsList)
    {
        Console.WriteLine("What is the name of the file you want to load? ");
        string userFileNameLoad = Console.ReadLine();

        if (!File.Exists(userFileNameLoad))
        {
            Console.WriteLine($"Error: File '{userFileNameLoad}'not found.");
            return;
        }

        string jsonString = File.ReadAllText(userFileNameLoad);

        GoalData loadedData = JsonSerializer.Deserialize<GoalData>(jsonString);

        _totalPoints = loadedData.TotalPoints;

        goalsList.Clear();
        goalsList.AddRange(loadedData.Goals);

        Console.WriteLine("Goals loaded successfully! ");
    }
}