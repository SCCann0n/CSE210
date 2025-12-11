public abstract class Activity
{
    protected int _duration;

    protected float _distance;

    protected float _pace;

    protected float _speed;

    protected DateTime _date;

    public Activity(DateTime date, int duration)
    {
        _duration = duration;

        _date = date;
    }

    public abstract string GetSummary();

    public abstract void Distance();

    public abstract void Speed();

    public abstract void Pace();
}