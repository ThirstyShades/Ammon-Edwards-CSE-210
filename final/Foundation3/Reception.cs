public class Reception : Event
{
    private string _eventType = "Reception";
    private string _rsvpEmail;

    public Reception(string title, string description, DateTime date, string time, Address address, string rsvpEmail) 
    : base(title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nEvent Type: {_eventType}\nRSVP Email: {_rsvpEmail}";
    }

    public override string GetShortDescription()
    {
        return $"Event Type: {_eventType}:\n{base.GetShortDescription()}";
    }
}
