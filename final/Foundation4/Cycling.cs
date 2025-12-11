public class Cycling : Activity
{
    float _bikeSpeed;

    public Cycling(float bikeSpeed, DateTime date, int duration) : base (date, duration)
    {
        _bikeSpeed = bikeSpeed;
    }
    
    public override void Distance()
    {
        _distance = _bikeSpeed * (_duration / 60f);
    }

    public override void Speed()
    {
        _speed = _bikeSpeed;
    }
    public override void Pace()
    {
        float pace = 60f/_bikeSpeed;
        _pace = pace;
    }
    public override string GetSummary()
    {
        Distance();
        Pace();
        Speed();
        return $"{_date.ToString("yyyy-MM-dd")} Cycling ({_duration:F2}m) - Distance: {_distance:F2}km, Speed: {_speed:F2}kph, Pace: {_pace:F2} min/km";
    }
}