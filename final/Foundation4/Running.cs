public class Running : Activity
{
    public double Distance { get; set; } // in miles

    public override double GetDistance()
    {
        return Distance;
    }

    public override double GetSpeed()
    {
        return Distance / (Duration / 60);
    }

    public override double GetPace()
    {
        return Duration / Distance;
    }
}