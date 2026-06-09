
public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {

    }
    public void Run()
    {
        //Storing the duration for running the activity.
        int runningDuration = base.GetDuration();

        //Displaying the starting message and the spinner for 5 seconds.
        Console.Clear();
        DisplayStartingMessage();
        base.ShowSpinner(5);

        Console.WriteLine("\n");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(runningDuration);

        //Continue the activity until the duration is complete.
        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in...");
            base.ShowCountDown(4);
            Console.WriteLine();
            Console.Write("Now breathe out...");
            base.ShowCountDown(6);

            Console.WriteLine("\n");

        }
        Console.WriteLine("Well done!!!");
        base.ShowSpinner(5);
        Console.WriteLine("\n");
        DisplayEndingMessage();
        base.ShowSpinner(5);

        Console.Clear();

    }
}