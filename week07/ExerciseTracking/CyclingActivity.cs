
public class CyclingActivity : Activity
{
    private double _speed;
    public CyclingActivity(string date, double length, double speed) : base(date, length)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        double minutes = base.GetLength();
        double distance = (_speed * minutes) / 60;
        return distance;
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        return 60 / _speed;
    }
    public override string GetSummary()
    {
        string date = base.GetDate();
        double minutes = base.GetLength();
        double distance = Math.Round(GetDistance(), 2);
        double speed = GetSpeed();
        double pace = Math.Round(GetPace(), 2);

        string summary = $"{date} Cycling({minutes} min) : Distance {distance} km, Speed: {speed} kph, Pace: {pace} min per km";
        return summary;
    }

}