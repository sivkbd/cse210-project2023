public class Party : Event
{
    private string host;

    public Party(string name, Address location, DateTime date, string host)
        : base(name, location, date)
    {
        this.host = host;
    }

    public override string GetInviteMessage()
    {
        return $"You're invited to a party hosted by {host} at {GetLocation()} on {GetDate()}!";
    }
}