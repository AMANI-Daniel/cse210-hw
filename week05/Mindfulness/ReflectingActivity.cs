public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();

    private List<string> _questions = new List<string>();

    private Random _rand = new Random();

    private List<string> _WorkingQuestionList = new List<string>();


    public ReflectingActivity(string name, string description, int duration) : base(name, description, duration)
    {
    }
    public void SetPrompts(string prompt)
    {
        _prompts.Add(prompt);
    }
    public void SetQuestions(string question)
    {
        _questions.Add(question);
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
        Console.WriteLine("Consider the following prompt:\n");
        DisplayPrompt();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        base.ShowCountDown(5);

        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(runningDuration);

        //Continue the activity until the duration is complete.
        while (DateTime.Now < endTime)
        {
            DisplayQuestion();
            base.ShowSpinner(10);
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine("Well done!!!");
        base.ShowSpinner(5);
        Console.WriteLine("\n");
        DisplayEndingMessage();
        base.ShowSpinner(5);

        Console.Clear();
        

    }

    public string GetRandomPrompt()
    {
        int index = _rand.Next(_prompts.Count);
        
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        

        if(_WorkingQuestionList.Count == 0)
        {
            _WorkingQuestionList = new List<string>(_questions);
        }
       
        int index = _rand.Next(_WorkingQuestionList.Count);
        string question = _WorkingQuestionList[index];
        _WorkingQuestionList.RemoveAt(index);
        return question;
        
    }

    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine($"---{prompt}---\n");
    }
    
    public void DisplayQuestion()
    {
        string question = GetRandomQuestion();
        Console.Write($">{question}");
    }
}