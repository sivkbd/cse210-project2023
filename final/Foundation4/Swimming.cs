public class Swimming : Activity
{
    public int Laps { get; set; }

    public override double GetDistance()
    {
        return Laps * 50 / 1609.34; // convert meters to miles
    }

    public override double GetSpeed()
    {
        return GetDistance() / (Duration / 60);
    }

    public override double GetPace()
    {
        return Duration / GetDistance();
    }
}