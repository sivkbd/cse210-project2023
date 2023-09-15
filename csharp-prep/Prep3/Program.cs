using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep3 World!");
        //Console.Write("What is the magic number ?");
        //string number = Console.ReadLine(); 
        //int mNumber = int.Parse(number);

        //Console.Write("What is your guess?");
        //string guess = Console.ReadLine();
        //int myGuess = int.Parse(guess);

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 30);

       

        int gNumber = 10;

        while (gNumber != number)
        {
            Console.Write("What is your guess?");
            gNumber = int.Parse(Console.ReadLine());
        

            if (number > gNumber)
            {
                Console.WriteLine("higher");
            }
            else if (number < gNumber)
            {
                Console.WriteLine("lower");
            }
            else
            {
                Console.WriteLine("correct");
            }
        }

    }
}