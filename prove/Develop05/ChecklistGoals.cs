using System.Text.Json.Serialization;

public class ChecklistGoal : Goal
{
    [JsonInclude]
    int _completedTimes = 0;

    [JsonInclude]
    int _goalTimes;

    [JsonInclude]
    int _bonusPoints;

    public ChecklistGoal(string name, int points, string description) : base(name, points, description)
    {

    }

    public ChecklistGoal() : base()
    {

    }

    public override int PointTotal()
    {

        int earned = _points;

        if (_completedTimes == _goalTimes)
        {
            earned += _bonusPoints;
        }

        return earned;

    }

    public override int Record()
    {
        _completedTimes++;

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

        Console.WriteLine("How many times should the goal be done?");
        int goalTimes = int.Parse(Console.ReadLine());

        Console.WriteLine($"Once the goals has been completed {goalTimes} times, how many bonus points?");
        int bonusPoints = int.Parse(Console.ReadLine());

        base._name = name;

        base._points = pointsValue;

        base._description = userDescription;

        _bonusPoints = bonusPoints;

        _goalTimes = goalTimes;
    }

    public override string GetGoal()
    {
        string finished = " ";

        if (_completedTimes == _goalTimes)
        {
            finished = "X";
        }

        string listString = $"[{finished}] {_name} ({_description}) -- Currently completed: {_completedTimes}/{_goalTimes}";

        return listString;

    }
}