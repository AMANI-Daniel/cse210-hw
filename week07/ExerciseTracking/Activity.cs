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

    public string GetSummary()
    {
        double distance = Math.Round(GetDistance(), 2);
        double speed = Math.Round(GetSpeed(), 2);
        double pace = Math.Round(GetPace(), 2);

        string summary = $"{_date} Running({_length} min) : Distance {distance} km, Speed: {speed} kph, Pace: {pace} min per km";
        return summary;
    }
}