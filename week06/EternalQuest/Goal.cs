
public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public string GetName()
    {
        return _shortName;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetPoints()
    {
        return _points;
    }
    public void SetPoints(int points)
    {
        _points += points;
    }
    public abstract void RecordEvent();
    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        string details;
        if (IsComplete())
        {
            details = $"[X] {_shortName}({_description}).";
        }
        else
        {
            details = $"[] {_shortName}({_description}).";
        }
        return details;
    }

    public abstract string GetStringRepresentation();


}