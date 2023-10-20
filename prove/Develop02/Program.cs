using System;

class Program
{
    static int GetChoice()
    {
        Console.WriteLine("Welcome to the journal program.");
        Console.WriteLine("Please choose an option from the menu below:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Save the journal");
        Console.WriteLine("4. Load the journal");
        Console.WriteLine("5. Exit");

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

        return choice;
    }

   
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        bool exit = false;
        while (!exit)
        {
            int choice = GetChoice();

            switch (choice)
            {
                case 1:
                    journal.WriteEntry();
                    break;
                case 2:
                    journal.DisplayJournal();
                    break;
                case 3:
                    journal.SaveToFile();
                    break;
                case 4:
                    journal.LoadFromFile();
                    break;
                case 5:
                    exit = true;
                    break;
            }

            Console.WriteLine();
        }

        Console.WriteLine("Thank you for using your journal program. Have a nice day!");
    }
}








