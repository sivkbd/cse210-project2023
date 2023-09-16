using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep5 World!");
        DisplayWelcomeMessage();

        string userName = Name();
        int userNumber = Number();

        int squaredNumber = SquareNumber(userNumber);

        Results(userName, squaredNumber);
    }    
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the programm");
    }

    static string Name()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }
    static int Number()
    {
        Console.Write("Please enter your favorite number:");
        int number = int.Parse(Console.ReadLine());

        return number;
    }
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void Results(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }


    
}