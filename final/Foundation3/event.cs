public abstract class Event
{
    protected string _eventTitle;

    protected string _description;

    protected DateTime _date;
    
    protected Address _address;

    public Event(string eventTitle, string description, DateTime date, Address address)
    {
        _eventTitle = eventTitle;

        _description = description;

        _date = date;

        _address = address;
    }

    public abstract string StandardDetails();

    public abstract string FullDetails();

    public abstract string ShortDescription();
}