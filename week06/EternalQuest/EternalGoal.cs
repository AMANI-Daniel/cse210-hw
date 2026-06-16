
public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {

    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Congulaturation! You have earned {base.GetPoints()} points");
    }
    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        string name = base.GetName();
        string description = base.GetDescription();
        int points = base.GetPoints();
        string representation = $"EternalGoal: {name}, {description}, {points}";
        return representation;
    }
}