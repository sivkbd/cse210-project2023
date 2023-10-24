public class Address
{
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }
}

public abstract class Event
{
    private Address location;
    private DateTime date;
    private string name;

    public Event(string name, Address location, DateTime date)
    {
        this.name = name;
        this.location = location;
        this.date = date;
    }

    public abstract string GetInviteMessage();

    public string GetLocation()
    {
        return $"{location.Street}, {location.City}, {location.State}, {location.Country}";
    }

    public string GetDate()
    {
        return date.ToString("d");
    }
}
