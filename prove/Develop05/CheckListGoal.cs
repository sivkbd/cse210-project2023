public class ChecklistGoal : Goal
{
    private int timesCompleted;

    public ChecklistGoal(string name, string description, int points) : base(name, description, points)
    {
        timesCompleted = 0;
    }

    public override void RecordEvent()
    {
        timesCompleted++;
        if (timesCompleted >= 3)
            isComplete = true;
    }
    public override bool IsComplete()
    {
        return isComplete;
    }

    public override string GetDetailsString()
    {
        return base.GetDetailsString() + $", Times Completed: {timesCompleted}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal: {name}, {description}, {points}, {timesCompleted}";
    }
}