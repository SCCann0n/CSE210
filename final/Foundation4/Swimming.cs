public class Swimming : Activity
{
    private float _lapNumb;

    public Swimming(float lapNumb, DateTime date, int duration) : base (date, duration)
    {
        _lapNumb = lapNumb;
    }
    
    public override void Distance()
    {
        _distance = (_lapNumb * 50)/1000;
    }
    public override void Speed()
    {
        _speed = 60f/_pace;
    }
    
    public override void Pace()
    {
        _pace = _duration/_distance;
    }
    public override string GetSummary()
    {
        Distance();
        Pace();
        Speed();
        return $"{_date.ToString("yyyy-MM-dd")} Swimming ({_duration:F2}m) - Distance: {_distance:F2}km, Speed: {_speed:F2}kph, Pace: {_pace:F2} min/km";
    }

}