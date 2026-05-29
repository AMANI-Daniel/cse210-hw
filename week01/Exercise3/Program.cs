using System;

class Program
{
    static void Main(string[] args)
    {

        bool choice = true;
        while (choice)
        {
            Random randomGenerator = new Random();
            int magicNum = randomGenerator.Next(1, 101);

            int guess = 0;
            int count = 0;
            while (guess != magicNum)
            {
                Console.Write("What is your guess? ");
                String guessText = Console.ReadLine();
                guess = int.Parse(guessText);
                count++;

                if (guess < magicNum)
                {
                    Console.WriteLine("Higher");
                }
                if (guess > magicNum)
                {
                    Console.WriteLine("Lower");
                }
            }

            Console.WriteLine("You guessed it!");
            Console.WriteLine($"You made {count} guesses");

            Console.Write("Would you like to continue playing(yes or no)? ");
            String user = Console.ReadLine();
            if (user == "yes")
            {
                choice = true;
            }
            else
            {
                choice = false;
                Console.WriteLine("Thank you very much for playing. Have a good day!");
            }
        }

        

        
    
    }


} 