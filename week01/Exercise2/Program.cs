using System;
using System.Data.Common;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is Grade in percentage? ");
        String userGrade = Console.ReadLine();
        int grades = int.Parse(userGrade);
        string letter = "";
        int remainder = grades % 10;

        string sign = "";
        if (remainder >= 7 || grades !< 94)
        {
            sign = "+";
        }
        if (remainder < 3)
        {
            sign = "-";
        }


        if (grades >= 90)
        {
            letter = "A" + sign;
        }
        else if (grades >= 80)
        {
            letter = "B" + sign;
        }
        else if (grades >= 70)
        {
            letter = "C" + sign;
        }
        else if (grades >= 60)
        {
            letter = "D" + sign;
        }
        else
        {
            letter = "F";
        }
        if (grades >= 70)
        {
            Console.WriteLine("Conguratulations!!! You've passed.");
        }
        else
        {
            Console.WriteLine("You have failes, but keep working hard to pass in th future.");
        }

        Console.WriteLine($"Your Grades letter is {letter}");

    }
}