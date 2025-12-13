public class Lecture : Event
{
    private string _speaker;

    private int _capacity;

    public Lecture(string eventTitle, string description, DateTime date, Address address, string speaker, int capacity)
     : base(eventTitle, description, date, address)
    {
        _speaker = speaker;

        _capacity = capacity;
    }

    public override string StandardDetails()
    {
        return $"{_eventTitle}, {_description}, {_date.ToString("yyyy-MM-dd hh:mm:ss")}, {_address} ";
    }

    public override string FullDetails()
    {
        return $"{StandardDetails()} - {_speaker} - Capacity: {_capacity}";
    }

    public override string ShortDescription()
    {
        return $"Lecture - {_eventTitle} - {_date.ToString("yyyy-MM-dd")}";
    }

}