public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) : base(name, description, points) { }

    public override void RecordEvent()
    {
        isComplete = true;
    }

    public override bool IsComplete()
    {
        return isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal: {name}, {description}, {points}, {isComplete}";
    }
}

