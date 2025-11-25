using System.Text.Json.Serialization;

public class EternalGoal : Goal
{
    [JsonInclude]
    int _timesCompleted;

    public EternalGoal(string name, int points, string description) : base(name, points, description)
    {

    }

    public EternalGoal() : base()
    {

    }

    public override int PointTotal()
    {
        return _points;
    }

    public override int Record()
    {
        _timesCompleted++;

        int earnedPoints = PointTotal();

        Console.WriteLine($"Congratulations! You have earned {_points} points!");

        return earnedPoints;
    }
    public override void CreateGoal()
    {
        Console.WriteLine("What is the name of your goal?");
        string name = Console.ReadLine();

        Console.WriteLine("How many points is the goal worth?");
        int pointsValue = int.Parse(Console.ReadLine());

        Console.WriteLine("What is the description of the goal?");
        string userDescription = Console.ReadLine();

        base._name = name;

        base._description = userDescription;

        base._points = pointsValue;
    }

    public override string GetGoal()
    {
        string finished = " ";

        string listString = $"[{finished}] {_name} ({_description})";

        return listString;

    }
}
