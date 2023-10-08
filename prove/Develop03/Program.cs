using System;
using System.Collections.Generic;
using System.Linq;

namespace ScriptureMemory
{
    
    
   
    // The main program class
    class Program
    {
        // The main method
        static void Main(string[] args)
        {
            // Create a scripture object with a reference and a text
            Scripture scripture = new Scripture(new Reference("Ephesians", 6, 11), "Put on the whole armour of God, that ye may be able to stand against the wiles of the devil.");

            // Clear the console screen and display the complete scripture
            Console.Clear();
            Console.WriteLine(scripture);

            // Prompt the user to press the enter key or type quit
            Console.WriteLine("\nPress the enter key to hide a word or type quit to end the program.");
            string input = Console.ReadLine();

            // Loop until the user types quit or all words are hidden
            while (input != "quit" && !scripture.AreAllWordsHidden())
            {
                // Hide a random word in the scripture
                scripture.HideRandomWord();

                // Clear the console screen and display the scripture again
                Console.Clear();
                Console.WriteLine(scripture);

                // Prompt the user again
                Console.WriteLine("\nPress the enter key to hide another word or type quit to end the program.");
                input = Console.ReadLine();
            }

            // End the program
            Console.WriteLine("\nThank you for using this program. Goodbye!");
        }
    }
}
