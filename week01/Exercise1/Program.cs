using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is Your First Name? ");
        String fname = Console.ReadLine();
        Console.Write("What is Your Last Name? ");
        String lname = Console.ReadLine();
        Console.WriteLine($"Your Name is {lname}, {fname} {lname}");
    }
}