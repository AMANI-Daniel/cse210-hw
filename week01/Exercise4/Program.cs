using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();
        int user = -9999999;

        //Prompting the user to enter a number until the user enter zero(0)
        while (user != 0)
        {
            Console.Write("Enter a number: ");
            String userText = Console.ReadLine();

            user = int.Parse(userText);
            if (user != 0)
            {
                numbers.Add(user);
            }
        }

        int sum = 0;

        int max = -1;
        int min = 9999999;
        // Calculating the sum and the largest number and smallest positive number
        foreach (int number in numbers)
        {
            sum += number;
            if (number > max)
            {
                max = number;
            }
            if (number < min && number > 0)
            {
                min = number;
            }

        }
        //Calculting the average
        int items = numbers.Count;
        double average = (double)sum / items;
       

        //Displaying the outputs to the user
        Console.WriteLine($"The Sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The maximum number in the list is: {max} ");
        Console.WriteLine($"The smallest positive number is: {min}");

        //Sorting the numbers in a list
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int sortedNumber in numbers)
        {
            Console.WriteLine(sortedNumber);
        }
    }
}