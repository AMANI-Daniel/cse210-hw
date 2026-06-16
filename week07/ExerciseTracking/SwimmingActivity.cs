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
}