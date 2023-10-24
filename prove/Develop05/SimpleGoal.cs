public class SimpleGoal : Goal
{
    public bool IsComplete { get; private set; }

    public override int Complete()
    {
        if (!IsComplete)
        {
            IsComplete = true;
            return Points;
        }
        return 0;
    }
}

