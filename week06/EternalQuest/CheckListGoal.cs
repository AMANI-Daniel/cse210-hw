public class CheckListGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public CheckListGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }
    public void SetAmount(int amount)
    {
        _amountCompleted = amount;
    }
    public override void RecordEvent()
    {
        _amountCompleted++;
        if(_amountCompleted == _target)
        {
            base.SetPoints(_bonus);
        }
        Console.WriteLine($"Congulaturation! You have earned {base.GetPoints()} points");

    }
    public override bool IsComplete()
    {
        if(_amountCompleted == _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetDetailsString()
    {
        string name = base.GetName();
        string description = base.GetDescription();
        string details;
        if (IsComplete())
        {
            details = $"[X] {name}({description}) -- Currently Completed: {_amountCompleted}/{_target}";
        }
        else
        {
            details = $"[] {name}({description}) -- Currently Completed: {_amountCompleted}/{_target}";
        }
        return details;
    }

    public override string GetStringRepresentation()
    {
        string name = base.GetName();
        string description = base.GetDescription();
        int points = base.GetPoints();
        string representation = $"CheckListGoal: {name}, {description}, {points},{_bonus}, {_target}, {_amountCompleted}";
        return representation;
    }

}