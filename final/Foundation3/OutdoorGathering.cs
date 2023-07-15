public class OutdoorGathering : Event
{
    private string _eventType = "Outdoor Gathering";
    private string _weather;

    public OutdoorGathering(string title, string description, DateTime date, string time, Address address, string weather)
        : base(title, description, date, time, address)
    {
        _weather = weather;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nEvent Type: {_eventType}\nWeather: {_weather}";
    }

    public override string GetShortDescription()
    {
        return $"Event Type: {_eventType}:\n{base.GetShortDescription()}";
    }
}
