public class Concert : Event
{
    private string band;

    public Concert(string name, Address location, DateTime date, string band)
        : base(name, location, date)
    {
        this.band = band;
    }

    public override string GetInviteMessage()
    {
        return $"Come see {band} at {GetLocation()} on {GetDate()}!";
    }
}