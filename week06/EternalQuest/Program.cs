//To show the creativity, I have created a list (List<Goal>) called availableGoals to work with not completed goals, so if the user chose to record the goal he/she only get none completed goals.


using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the EternalQuest Project.");

        int choice = 0;
        GoalManager goalManager = new GoalManager();
        while (choice != 6)
        {
            //Display the current points and list the menu option to choose
            goalManager.DisplayPlayerInfo();
            goalManager.Start();
            Console.Write("Select a choice from the menu: ");
            string choiceText = Console.ReadLine();
            choice = int.Parse(choiceText);

            switch (choice)
            {
                case 1:
                    goalManager.ListGoalNames();
                    goalManager.CreateGoal();
                    break;

                case 2:
                    goalManager.ListGoalDetails();
                    break;

                case 3:
                    goalManager.SaveGoals();
                    break;

                case 4:
                    goalManager.LoadGoals();
                    break;

                case 5:
                    goalManager.RecordEvent();
                    break;

                default:
                    break;
            }

        }
    }
}