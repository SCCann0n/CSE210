using System.Text.Json.Serialization;

[JsonDerivedType(typeof(SimpleGoal), typeDiscriminator: "simple")]
[JsonDerivedType(typeof(EternalGoal), typeDiscriminator: "eternal")]
[JsonDerivedType(typeof(ChecklistGoal), typeDiscriminator: "checklist")]

public abstract class Goal
{
    [JsonInclude]
    protected string _name;

    [JsonInclude]
    protected string _description;

    [JsonInclude]
    protected int _points;

    public Goal(string name, int points, string description)
    {
        _name = name;

        _points = points;

        _description = description;
    }

    public Goal()
    {
        
    }

    public abstract int PointTotal();

    public abstract int Record();

    public abstract void CreateGoal();

    public abstract string GetGoal();    
}