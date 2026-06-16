public class RunningActivity : Activity
{
    private double _distance;
    public RunningActivity(string date, double length, double distance) : base(date, length)
    {
        _distance = distance;
    }
    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        double minutes = base.GetLength();
        double speed = (_distance / minutes) * 60;
        return speed;
    }
    public override double GetPace()
    {
        double minutes = base.GetLength();
        double pace = minutes / _distance;
        return pace;
    }

    public override string GetSummary()
    {
        string date = base.GetDate();
        double minutes = base.GetLength();
        double distance = GetDistance();
        double speed = Math.Round(GetSpeed(), 2);
        double pace = Math.Round(GetPace(), 2);

        string summary = $"{date} Running({minutes} min) : Distance {distance} km, Speed: {speed} kph, Pace: {pace} min per km";
        return summary;
    }

}