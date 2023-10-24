using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var activities = new List<Activity>
        {
            new Running { Name = "Running", Date = DateTime.Now, Duration = 30, Distance = 3 },
            new Cycling { Name = "Cycling", Date = DateTime.Now.AddDays(-1), Duration = 60, Speed = 15 },
            new Swimming { Name = "Swimming", Date = DateTime.Now.AddDays(-2), Duration = 45, Laps = 20 },
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
