public abstract class Activity
{
    private string _date;
    private double _length;

    public double GetLength()
    {
        return _length;
    }
    public string GetDate()
    {
        return _date;
    }
    public Activity(string date, double length)
    {
        _date = date;
        _length = length;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public abstract string GetSummary();
}