using System;

class Program
{


    //The main function that calls the other functions
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();

        int userNumber = PromptUserNumber();
        int squaredNum = SquareNumber(userNumber);
        DisplayResult(userName, squaredNum);

    }

    //A fucntion that displays the message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }


    //A function that asks for and returns the user's name
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");

        String name = Console.ReadLine();
        return name;
    }

    //A function that asks for and returns the user's favorite number

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        String stringNumber = Console.ReadLine();

        int number = int.Parse(stringNumber);
        return number;

    }

    //A function that accepts an integer as a parameter and returns that number squared

    static int SquareNumber(int num)
    {
        return num * num;
    }
    
    static void DisplayResult(string userName, int squaredNum)
    {
        Console.WriteLine($"{userName}, the square of your favorite number is {squaredNum}");
    }

}