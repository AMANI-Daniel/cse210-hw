//As the feature enhancement, I created and new member variable in a ReflectingActivity class to store the working list in order to prevent displaying duplicate questions to the user until all questions in the list are asked.

using System;


class Program
{
    static void Main(string[] args)
    {
        int choice = 0;

        while(choice != 4)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1.Start breathing activity");
            Console.WriteLine("2.Start reflection activity");
            Console.WriteLine("3.Start listing activity");
            Console.WriteLine("4.Quit");
            Console.Write("Select a choice from the menu: ");
            string stringChoice = Console.ReadLine();
            choice = int.Parse(stringChoice);

            switch (choice)
            {
                case 1:
                    string name1 = "Breathing Activity.";
                    string description1 = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.\n";
                    Console.Clear();
                    Console.WriteLine($"Welcome to the {name1}\n");
                    Console.WriteLine(description1);
                    Console.Write("How long, in seconds, would you like for your session? ");
                    string textDuration1 = Console.ReadLine();
                    int duration1 = int.Parse(textDuration1);

                    BreathingActivity breathingActivity = new BreathingActivity(name1, description1, duration1);
                    breathingActivity.Run();
                    break;

                case 2:
                    string name2 = "Reflection Activity.";
                    string description2 = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.\n";
                    Console.Clear();

                    Console.WriteLine($"Welcome to the {name2}\n");
                    Console.WriteLine(description2);
                    Console.Write("How long, in seconds, would you like for your session? ");
                    string textDuration2 = Console.ReadLine();
                    int duration2 = int.Parse(textDuration2);
                    ReflectingActivity reflectingActivity = new ReflectingActivity(name2, description2, duration2);

                    //Adding prompts to the list of prompts.
                    reflectingActivity.SetPrompts("Think of a time when you stood up for someone else.");
                    reflectingActivity.SetPrompts("Think of a time when you did something really difficult.");
                    reflectingActivity.SetPrompts("Think of a time when you helped someone in need.");
                    reflectingActivity.SetPrompts("Think of a time when you did something truly selfless.");

                    //Adding questions to the question list.

                    reflectingActivity.SetQuestions("Why was this experience meaningful to you? ");
                    reflectingActivity.SetQuestions("Have you ever done anything like this before? ");
                    reflectingActivity.SetQuestions("How did you get started? ");
                    reflectingActivity.SetQuestions("How did you feel when it was complete? ");
                    reflectingActivity.SetQuestions("What made this time different than other times when you were not as successful? ");
                    reflectingActivity.SetQuestions("What is your favorite thing about this experience? ");
                    reflectingActivity.SetQuestions("What could you learn from this experience that applies to other situations? ");
                    reflectingActivity.SetQuestions("What did you learn about yourself through this experience? ");
                    reflectingActivity.SetQuestions("How can you keep this experience in mind in the future? ");

                    reflectingActivity.Run();
                    break;

                case 3:
                    string name3 = "Listing Activity.";
                    string description3 = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.\n";
                    Console.Clear();

                    Console.WriteLine($"Welcome to the {name3}\n");
                    Console.WriteLine(description3);
                    Console.Write("How long, in seconds, would you like for your session? ");
                    string textDuration3 = Console.ReadLine();
                    int duration3 = int.Parse(textDuration3);

                    ListingActivity listingActivity = new ListingActivity(name3, description3, duration3);

                    //Adding prompts in the list of prompts
                    listingActivity.SetPrompts("Who are people that you appreciate?");
                    listingActivity.SetPrompts("What are personal strengths of yours?");
                    listingActivity.SetPrompts("Who are people that you have helped this week?");
                    listingActivity.SetPrompts("When have you felt the Holy Ghost this month?");
                    listingActivity.SetPrompts("Who are some of your personal heroes?");

                    listingActivity.Run();
                    break;
                default:
                    break;
            }
           
        }
    }
}