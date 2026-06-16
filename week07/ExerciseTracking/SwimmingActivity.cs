public class SwimmingActivity : Activity
{
    private int _laps;
    public SwimmingActivity(string date, double length, int laps) : base(date, length)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        double distance = _laps * 50 / 1000;
        return distance;
    }
    public override double GetSpeed()
    {
        double minutes = base.GetLength();
        double distance = GetDistance();
        double speed = (distance / minutes) * 60;
        return speed;
    }
    public override double GetPace()
    {
        double speed = GetSpeed();
        return 60 / speed;
    }
    public override string GetSummary()
    {
        string date = base.GetDate();
        double minutes = base.GetLength();
        double distance = Math.Round(GetDistance(), 2);
        double speed = Math.Round(GetSpeed(), 2);
        double pace = Math.Round(GetPace(), 2);

        string summary = $"{date} Swimming({minutes} min) : Laps: {_laps} laps; Distance: {distance} km, Speed: {speed} kph, Pace: {pace} min per km";
        return summary;
    }
}