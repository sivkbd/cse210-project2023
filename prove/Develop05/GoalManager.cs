public class GoalManager
{
    private List<Goal> goals = new List<Goal>();

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public int CompleteGoal(string name)
    {
        var goal = goals.Find(g => g.Name == name);
        if (goal != null)
        {
            return goal.Complete();
        }
        throw new Exception("Goal not found");
    }

    public void SaveGoals(string filename)
    {
        using (var stream = File.Open(filename, FileMode.Create))
        {
            var formatter = new BinaryFormatter();
            formatter.Serialize(stream, goals);
        }
    }

    public void LoadGoals(string filename)
    {
        using (var stream = File.Open(filename, FileMode.Open))
        {
            var formatter = new BinaryFormatter();
            goals = (List<Goal>)formatter.Deserialize(stream);
        }
    }
}
