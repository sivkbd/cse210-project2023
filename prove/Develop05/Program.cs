
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

class Program
{
    static void Main(string[] args)
    {
        
        
            public List<Goal> Goals { get; private set; } = new List<Goal>();
            public int Score { get; private set; }

            public void CreateGoal<T>(string name, int points, int target = 0) where T : Goal, new()
            {
                var goal = new T { Name = name, Points = points };
                if (goal is ChecklistGoal checklistGoal)
                {
                    checklistGoal.Target = target;
                }
                Goals.Add(goal);
            }

            public void RecordEvent(string name)
            {
                var goal = Goals.Find(g => g.Name == name);
                if (goal != null)
                {
                    Score += goal.Complete();
                }
            }

            public void DisplayGoals()
            {
                foreach (var goal in Goals)
                {
                    var status = "[ ]";
                    if (goal is SimpleGoal simpleGoal && simpleGoal.IsComplete ||
                        goal is ChecklistGoal checklistGoal && checklistGoal.Count == checklistGoal.Target)
                    {
                        status = "[X]";
                    }
                    Console.WriteLine($"{status} {goal.Name}");
                }
            }

            public void Save(string filename)
            {
                using (var stream = File.Open(filename, FileMode.Create))
                {
                    var formatter = new BinaryFormatter();
                    formatter.Serialize(stream, this);
                }
            }

            public static User Load(string filename)
            {
                using (var stream = File.Open(filename, FileMode.Open))
                {
                    var formatter = new BinaryFormatter();
                    return (User)formatter.Deserialize(stream);
                }
            }
        



    }
}
