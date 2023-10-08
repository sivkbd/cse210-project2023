using System;
using System.Collections.Generic;
using System.IO;

// A class to represent a journal entry
class Entry
{
    public string Prompt { get; set; } // The prompt that was given to the user
    public string Response { get; set; } // The response that the user wrote
    public DateTime Date { get; set; } // The date when the entry was created

    // A constructor that takes a prompt, a response, and a date
    public Entry(string prompt, string response, DateTime date)
    {
        Prompt = prompt;
        Response = response;
        Date = date;
    }

    // A method to display the entry to the console
    public void Display()
    {
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"Response: {Response}");
        Console.WriteLine($"Date: {Date.ToShortDateString()}");
        Console.WriteLine();
    }
}

