using System;

class Program
{
    static void Main(string[] args)
    {

        //Creating list of activities
        List<Activity> activities = new List<Activity>();
        //Creating the activities
        RunningActivity runningActivity = new RunningActivity("03 Nov 2024", 30, 4.8);
        CyclingActivity cyclingActivity = new CyclingActivity("10 June 2025", 20, 12);
        SwimmingActivity swimmingActivity = new SwimmingActivity("02 Jan 2026", 22, 50);
        activities.Add(runningActivity);
        activities.Add(cyclingActivity);
        activities.Add(swimmingActivity);

        foreach(Activity activity in activities)
        {
            string summary = activity.GetSummary();
            Console.WriteLine(summary);
        }     
    }
}
