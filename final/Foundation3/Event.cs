public class Event // base class for all events
{
    private string _title;
    private string _description;
    private DateTime _date;
    private string _time;
    private Address _address;

    public Event(string title, string description, DateTime date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetStandardDetails()// the method ToShortDateString() is built in to Datetime and takes a date and makes it short and nice. 
    {
        return ($"Title: {_title}\nDescription: {_description}\nDate: {_date.ToShortDateString()}\nTime: {_time}\nAddress: {_address.GetAddressDetails()}");
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public virtual string GetShortDescription()
    {
        return $"Title: {_title}\nDate: {_date.ToShortDateString()}";
    }
}