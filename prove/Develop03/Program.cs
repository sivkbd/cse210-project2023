using System;
using System.Collections.Generic;
using System.Linq;

namespace ScriptureMemory
{
    
    
    class Program
    {
        // The main method
        static void Main(string[] args)
        {
            
            Scripture scripture = new Scripture(new Reference("Ephesians", 6, 11), "Put on the whole armour of God, that ye may be able to stand against the wiles of the devil.");

            Console.Clear();
            Console.WriteLine(scripture);

            Console.WriteLine("\nPress the enter key to hide a word or type quit to end the program.");
            string input = Console.ReadLine();

            while (input != "quit" && !scripture.AreAllWordsHidden())
            {
                scripture.HideRandomWord();

                Console.Clear();
                Console.WriteLine(scripture);

                Console.WriteLine("\nPress the enter key to hide another word or type quit to end the program.");
                input = Console.ReadLine();
            }

            Console.WriteLine("\nThank you for using this program. Goodbye!");
        }
    }
}
