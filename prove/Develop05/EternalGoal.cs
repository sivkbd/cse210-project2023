public class EternalGoal : Goal
{
    private int timesCompleted;

    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        timesCompleted = 0;
    }

    public override void RecordEvent()
    {
        timesCompleted++;
        if (timesCompleted >= 5)
            isComplete = true;
    }

    public override bool IsComplete()
    {
        return isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal: {name}, {description}, {points}, {timesCompleted}";
    }
}