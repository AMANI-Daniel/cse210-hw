using System;

class Program
{
    static void Main(string[] args)
    {
        //Creating an instance assignment class

        Assignment assignment = new Assignment("Daniel", "Programming");

        string summary = assignment.GetSummary();

        Console.WriteLine(summary);
        Console.WriteLine("----------------------------------------");


        MathAssignment mathAssignment = new MathAssignment("Amani", "Fractions", "Section 7.3", "Problems 9-18");
    
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        Console.WriteLine("----------------------------------------");

        WritingAssignment writingAssignment = new WritingAssignment("Rose", "European History", "The Causes of World War II");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());


    }
}