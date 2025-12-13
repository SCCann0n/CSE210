public class Reception : Event
{
    bool _RSVP;

    string _email;

    public Reception(string eventTitle, string description, DateTime date, Address address, bool RSVP, string email) 
    : base(eventTitle, description, date, address)
    {
        _RSVP = RSVP;

        _email = email;
    }
    
    public override string StandardDetails()
    {
        return $"{_eventTitle}, {_description}, {_date.ToString("yyyy-MM-dd hh:mm:ss")}, {_address} ";
    }

    public override string FullDetails()
    {
        return $"{StandardDetails()} - {_email}";
    }

    public override string ShortDescription()
    {
        return $"Reception - {_eventTitle} - {_date.ToString("yyyy-MM-dd")}";
    }
}