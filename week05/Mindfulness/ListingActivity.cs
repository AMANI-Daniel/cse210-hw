public class ListingActivity : Activity
{
    private int _count = 0;
    private List<string> _prompts = new List<string>();

    public ListingActivity(string name, string description, int duration) : base(name, description, duration)
    {

    }
    public void SetPrompts(string prompt)
    {
        _prompts.Add(prompt);
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

        //Displaying the prompt to the user.
        Console.WriteLine("List as many responses you can to the following prompt.");
        GetRandomPrompt();
        Console.Write("You may begin in: ");
        base.ShowCountDown(5);
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(runningDuration);

        //Continue the activity until the duration is complete.
        while (DateTime.Now < endTime)
        {
            Console.Write(">");
            string user = Console.ReadLine();
            GetListFromUser().Add(user);
            _count += 1;
        }
        Console.WriteLine($"You listed {_count} items!");
        Console.WriteLine();
        Console.WriteLine("Well done!!!");
        base.ShowSpinner(5);
        Console.WriteLine("\n");
        DisplayEndingMessage();
        base.ShowSpinner(5);

        Console.Clear();
    }

    public void GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string prompt = _prompts[index];
        Console.WriteLine($"---{prompt}---");
    }
    public List<string> GetListFromUser()
    {
        List<string> strings = new List<string>();
        return strings;
    }
}