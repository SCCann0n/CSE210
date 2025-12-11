public class Running : Activity
{
    float _runDist;

    public Running(float runDist, DateTime date, int duration) : base (date, duration)
    {
        _runDist = runDist;
    }

    public override void Distance()
    {
        _distance = _runDist;
    }
    public override void Speed()
    {
        _speed = (_runDist/_duration)* 60;
    }
    public override void Pace()
    {
        _pace = _duration/_runDist;
    }
    public override string GetSummary()
    {
        Pace();
        Speed();
        return $"{_date.ToString("yyyy-MM-dd")} Running ({_duration:F2}m) - Distance: {_runDist:F2}km, Speed: {_speed:F2}kph, Pace: {_pace:F2} min/km";
    }

    
}