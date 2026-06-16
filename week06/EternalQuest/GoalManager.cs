
public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }
    public void Start()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1.Create New Goal");
        Console.WriteLine("2.List Goals");
        Console.WriteLine("3.Save Goals");
        Console.WriteLine("4.Load Goals");
        Console.WriteLine("5.Record Event");
        Console.WriteLine("6.Quit");
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine();
        Console.WriteLine($"You have {_score} points.\n");
    }
    public void ListGoalNames()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1.Simple Goal");
        Console.WriteLine("2.Eternal Goal");
        Console.WriteLine("3.Checklist Goal");
    }
    public void ListGoalDetails()
    {
        Console.WriteLine("The Goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }
    public void CreateGoal()
    {
        Console.Write("Which type of Goal would you like to create? ");
        string chosenGoalText = Console.ReadLine();
        int chosenGoal = int.Parse(chosenGoalText);

        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string goalDescription = Console.ReadLine();

        Console.Write("What is the amount of points associated witht this goal? ");
        string goalPointsText = Console.ReadLine();
        int goalPoints = int.Parse(goalPointsText);

        if (chosenGoal == 1)
        {
            SimpleGoal simpleGoal = new SimpleGoal(goalName, goalDescription, goalPoints);


            _goals.Add(simpleGoal);
        }
        else if (chosenGoal == 2)
        {
            EternalGoal eternalGoal = new EternalGoal(goalName, goalDescription, goalPoints);

            _goals.Add(eternalGoal);
        }
        else if (chosenGoal == 3)
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            string goalTargetText = Console.ReadLine();
            int goalTarget = int.Parse(goalTargetText);

            Console.Write("What is the bonus for accomplishing that many times? ");
            string goalBonusText = Console.ReadLine();
            int goalBonus = int.Parse(goalBonusText);

            CheckListGoal checkListGoal = new CheckListGoal(goalName, goalDescription, goalPoints, goalTarget, goalBonus);

            _goals.Add(checkListGoal);
        }
        else
        {
            Console.WriteLine("Invalid choise.");
        }

    }
    public void RecordEvent()
    {
        List<Goal> availableGoals = new List<Goal>();
        for (int i = 0; i < _goals.Count; i++)
        {
            if (!_goals[i].IsComplete())
            {
                availableGoals.Add(_goals[i]);
                string name = _goals[i].GetName();
                Console.WriteLine($"{availableGoals.Count}. {name}");
            }


        }
        
        Console.Write("Which goal did you accomplish? ");
        string accomplishedText = Console.ReadLine();
        int accomplishedGoal = int.Parse(accomplishedText);

        Goal goal = availableGoals[accomplishedGoal - 1];

        goal.RecordEvent();

        _score += goal.GetPoints();
        Console.WriteLine($"You now have {_score} points");
       
    }
    public void SaveGoals()
    {
        Console.Write("What is the file name for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach(Goal g in _goals)
            {
                string representation = g.GetStringRepresentation();
                outputFile.WriteLine(representation);
            }
        }
    }
    public void LoadGoals()
    {
        Console.Write("What is the name of the file you want to load? ");
        string filename = Console.ReadLine();

        string[] lines = File.ReadAllLines(filename);

        //The first line is a score
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(':');

            string goalType = parts[0].Trim();
            string goalData = parts[1].Trim();

            string[] values = goalData.Split(',');

            if (goalType == "SimpleGoal")
            {
                string name = values[0].Trim();
                string description = values[1].Trim();
                int points = int.Parse(values[2].Trim());

                SimpleGoal goal = new SimpleGoal(name, description, points);
                goal.SetCompleted(bool.Parse(values[3]));

                _goals.Add(goal);
            }
            else if (goalType == "EternalGoal")
            {
                string name = values[0].Trim();
                string description = values[1].Trim();
                int points = int.Parse(values[2].Trim());

                EternalGoal goal = new EternalGoal(name, description, points);

                _goals.Add(goal);
            }
            else if (goalType == "CheckListGoal")
            {
                string name = values[0].Trim();
                string description = values[1].Trim();
                int points = int.Parse(values[2].Trim());
                int bonus = int.Parse(values[3].Trim());
                int target = int.Parse(values[4].Trim());
                int amount = int.Parse(values[5].Trim());

                CheckListGoal goal =
                    new CheckListGoal(name, description, points, target, bonus);

                goal.SetAmount(amount);

                _goals.Add(goal);
            }
        }
    }

}