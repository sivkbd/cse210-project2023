public abstract class Activity
{
    public string Name { get; set; }
    public DateTime Date { get; set; }
    public double Duration { get; set; } // in minutes

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{Date.ToString("dd MMM yyyy")} {Name} ({Duration} min) - Distance: {GetDistance():0.0} miles, Speed: {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
    }
}