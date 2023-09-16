using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep4 World!");
        Console.WriteLine("Enter a list of numbers, type 0 when finished");

        List<int> numbers = new List<int>();

        int number = -1;
        while (number != 0)
        {
            Console.Write("Enter the number: ");
            string number12 = Console.ReadLine();
            number  =   int.Parse(number12);
            if (number != 0)
            {
                numbers.Add(number);
            }

    
    }


    int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

    int max = numbers[0];

    foreach (int num in numbers)
        {
            if (num > max)
            {
                // if this number is greater than the max, we have found the new max!
                max = num;
            }
            }

            Console.WriteLine($"The max is: {max}");
    

        }
        
}