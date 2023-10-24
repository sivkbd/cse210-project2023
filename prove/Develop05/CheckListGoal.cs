



public class ChecklistGoal : Goal
{
    public int Target { get; set; }
    public int Count { get; private set; }

    public override int Complete()
    {
        if (Count < Target)
        {
            Count++;
            if (Count == Target)
            {
                return Points * 2;  // bonus points
            }
            return Points;
        }
        return 0;
    }
}
