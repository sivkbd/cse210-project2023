public abstract class Goal
{
    protected string name;
    protected string description;
    protected bool isComplete;
    protected int points;

    public Goal(string name, string description, int points)
    {
        this.name = name;
        this.description = description;
        this.points = points;
        this.isComplete = false;
    }
     public abstract void RecordEvent();
    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        return $"Name: {name}, Description: {description}, Is Complete: {isComplete}";
    }

    public abstract string GetStringRepresentation();
}