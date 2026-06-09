
public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public int GetDuration()
    {
        return _duration;
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine("Get ready....");
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine($"You have completed another {_duration} seconds fot the {_name}");
    }
    public void ShowSpinner(int seconds)
    {
        List<string> spinnerStrings = new List<string>();
        spinnerStrings.Add("|");
        spinnerStrings.Add("/");
        spinnerStrings.Add("-");
        spinnerStrings.Add("\\");
        spinnerStrings.Add("|");
        spinnerStrings.Add("/");
        spinnerStrings.Add("-");
        spinnerStrings.Add("\\");


        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;
        while (DateTime.Now < endTime)
        {
            string spinner = spinnerStrings[i];
            Console.Write(spinner);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if(i >= spinnerStrings.Count)
            {
                i = 0;
            }
        }

    }

    public void ShowCountDown(int seconds)
    {

        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

    }
    
}