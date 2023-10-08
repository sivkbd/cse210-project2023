using System;

class Program
{
    // A method to display a menu and get the user's choice
    static int GetChoice()
    {
        // Display the menu options
        Console.WriteLine("Welcome to your journal program.");
        Console.WriteLine("Please choose an option from the menu below:");
        Console.WriteLine("1. Write a new entry");
        Console.WriteLine("2. Display the journal");
        Console.WriteLine("3. Save the journal to a file");
        Console.WriteLine("4. Load the journal from a file");
        Console.WriteLine("5. Exit the program");

        // Get the user's input and validate it
        int choice = 0;
        bool valid = false;
        while (!valid)
        {
            try
            {
                choice = int.Parse(Console.ReadLine());
                if (choice >= 1 && choice <= 5)
                {
                    valid = true;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }

        // Return the user's choice
        return choice;
    }

   
 // The main method of the program
    static void Main(string[] args)
    {
        // Create a new journal object
        Journal journal = new Journal();

        // Loop until the user chooses to exit
        bool exit = false;
        while (!exit)
        {
            // Get the user's choice from the menu
            int choice = GetChoice();

            // Perform the corresponding action based on the user's choice
            switch (choice)
            {
                case 1:
                    // Write a new entry to the journal
                    journal.WriteEntry();
                    break;
                case 2:
                    // Display the journal to the console
                    journal.DisplayJournal();
                    break;
                case 3:
                    // Save the journal to a file
                    journal.SaveToFile();
                    break;
                case 4:
                    // Load the journal from a file
                    journal.LoadFromFile();
                    break;
                case 5:
                    // Exit the program
                    exit = true;
                    break;
            }

            // Add a blank line for spacing
            Console.WriteLine();
        }

        // Display a farewell message
        Console.WriteLine("Thank you for using your journal program. Have a nice day!");
    }
}








