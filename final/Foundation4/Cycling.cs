public class Cycling : Activity
{
    public double Speed { get; set; } // in mph

    public override double GetDistance()
    {
        return Speed * (Duration / 60);
    }

    public override double GetSpeed()
    {
        return Speed;
    }

    public override double GetPace()
    {
        return 60 / Speed;
    }
}