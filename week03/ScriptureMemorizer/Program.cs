//To show creativity, the program ask the user for number of words to hide and continue until the whole scripture is hidden.
using System;

class Program
{
    static void Main(string[] args)
    {

        string text = "For God so love the world that he gave one and only Son that whoever believes in him shall not perish but have eternal life.";
        //Creating the new Reference instance and pass in the book, chapeter and veres. Then pass the reference and the text to scripture instance.

        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference, text);


        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            //Ask the user for the number of words to hide
            int number = 0;
            if (!scripture.IsCompletelyHidden())
            {
                Console.Write("What is the number of words you want to hide? ");
                string textNumber = Console.ReadLine();
                number = int.Parse(textNumber);
            }

            //Stop if ecverything is hidden
            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("\nAll words are hidden. If you don't memorize the scripture reload the program until you are confident.");
                break;
            }

            Console.Write("Press Enter to continue or type 'quit' to finish. ");
            string choice = Console.ReadLine().ToLower();

            if (choice == "quit")
            {
                break;
            }
            scripture.HideRandomWords(number);

        }
    }
}