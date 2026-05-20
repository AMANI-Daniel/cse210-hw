//To extend the core requirements, I modified the program using(ToString(MM/dd/yyy HH:mm:ss) funntion) so that it can store the date and time with hours, minutes and seconds to track the time exactly.

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        //Create instances of classes(Journal, Entry, and PromptGenerator)
        PromptGenerator thePromptGenerator = new PromptGenerator();
        Journal theJournal = new Journal();

        //Adding prompts to the PromptGenerator

        thePromptGenerator._prompts.Add("What is the most thing you were supposed to do today? ");
        thePromptGenerator._prompts.Add("What was the most part of your day? ");
        thePromptGenerator._prompts.Add("What you were supposed to do, but not done? ");
        thePromptGenerator._prompts.Add("What you did, but were not planned? ");
        thePromptGenerator._prompts.Add("What was the scripture verse of today? ");
        thePromptGenerator._prompts.Add("What will be the first thing to do tommorrow? ");


        //Displaying choices the user to select

        Console.WriteLine("Welcome to Journal Program!");

        int choice = 0;

        while(choice != 5)
        {
            Console.WriteLine("Please select one of the following choices.");
            Console.WriteLine("1.Write");
            Console.WriteLine("2.Display");
            Console.WriteLine("3.Save");
            Console.WriteLine("4.Load");
            Console.WriteLine("5.Quit");

            Console.Write("What would you like to do? ");
            string userText = Console.ReadLine();

            choice = int.Parse(userText);

            if(choice != 5)
            {
                switch (choice)
                {
                    case 1:
                        Entry anEntry = new Entry();
                        DateTime theCurrentDate = DateTime.Now;
                        string entryDate = theCurrentDate.ToString("MM/dd/yyyy HH:mm:ss");
                        anEntry._date = entryDate;
                        string randomText = thePromptGenerator.GetRandomPrompt();
                        anEntry._promptText = randomText;
                        Console.Write(randomText);
                        string answer = Console.ReadLine();
                        anEntry._entryText = answer;

                        theJournal.AddEntry(anEntry);

                        break;
                    case 2:
                        theJournal.DisplayAll();
                        break;

                    case 3:

                        Console.Write("What is the name of the file? ");
                        string fileName = Console.ReadLine();

                        theJournal.SaveToFile(fileName);
                        break;
                    case 4:
                        Console.Write("What is the name of the file your want to load? ");
                        string loadFile = Console.ReadLine();

                        theJournal.LoadFromFile(loadFile);
                        break;
                    default:
                        Console.WriteLine("There is no such choice. Please try again!");
                        break;
                }
            }

           
        }

    }
}