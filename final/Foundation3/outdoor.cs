public class Outdoor : Event
{
    private string _forecast;

    public Outdoor(string eventTitle, string description, DateTime date, Address address, string forecast)
     : base(eventTitle, description, date, address)
    {
        _forecast = forecast;
    }
    
    public override string StandardDetails()
    {
        return $"{_eventTitle}, {_description}, {_date.ToString("yyyy-MM-dd hh:mm:ss")}, {_address} ";
    }

    public override string FullDetails()
    {
        return $"{StandardDetails()} - {_forecast}";
    }

    public override string ShortDescription()
    {
        return $"Outdoor - {_eventTitle} - {_date.ToString("yyyy-MM-dd")}";
    }
}