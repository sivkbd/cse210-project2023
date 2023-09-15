using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("What is your grade score?");
        string marks = Console.ReadLine();
        int gradeScore = int.Parse(marks);
        
        string letter = "";

        if (gradeScore >= 90)
        {
            letter = "A";
        }
        else if (gradeScore >= 80)
        {
            letter = "B";
        }
        else if (gradeScore >= 70)
        {
            letter = "C";
        }
        else if (gradeScore >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"your letter is {letter}");

        if (gradeScore >= 70)
        {
            Console.WriteLine("Congratulations, you passed!!!");
        }
        else
        {
            Console.WriteLine("better luck next time");
        }

    }
}