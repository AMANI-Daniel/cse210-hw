public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public void SetCompleted(bool completed)
    {
        _isComplete = completed;
    }
    public override void RecordEvent()
    {
        _isComplete = true;

        Console.WriteLine($"Congulaturation! You have earned {base.GetPoints()} points");
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        string name = base.GetName();
        string description = base.GetDescription();
        int points = base.GetPoints();
        string representation = $"SimpleGoal: {name}, {description}, {points}, {_isComplete}";

        return representation;
    }
}