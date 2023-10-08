class Journal
{
    public List<Entry> Entries { get; set; } 

    public Journal()
    {
        Entries = new List<Entry>();
    }

    public void WriteEntry()
    {
        string[] prompts = new string[]
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What is something I learned today?",
            "What is something I am grateful for today?",
            "What is something I want to improve on tomorrow?",
            "What is something I am looking forward to tomorrow?",
            "What is something I did today that made me happy?"
        };

        Random random = new Random();
        int index = random.Next(prompts.Length);
        string prompt = prompts[index];

        Console.WriteLine($"Your prompt for today is: {prompt}");
        Console.WriteLine("Please write your response below:");
        string response = Console.ReadLine();

        DateTime date = DateTime.Now;
        Entry entry = new Entry(prompt, response, date);

        Entries.Add(entry);

        Console.WriteLine("Your entry has been saved.");
    }

    public void DisplayJournal()
    {
        if (Entries.Count == 0)
        {
            Console.WriteLine("Your journal is empty.");
            return;
        }

        Console.WriteLine("Your journal entries are:");
        foreach (Entry entry in Entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile()
    {
        Console.WriteLine("Please enter a filename to save your journal:");
        string filename = Console.ReadLine();

        StreamWriter writer = new StreamWriter(filename);

        foreach (Entry entry in Entries)
        {
            writer.WriteLine($"{entry.Prompt},{entry.Response},{entry.Date}");
        }

        writer.Close();
        Console.WriteLine($"Your journal has been saved to {filename}.");
    }

    public void LoadFromFile()
    {
        Console.WriteLine("Please enter a filename to load your journal:");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine($"The file {filename} does not exist.");
            return;
        }

        StreamReader reader = new StreamReader(filename);

        Entries.Clear();

        while (!reader.EndOfStream)
        {
            string line = reader.ReadLine();
            string[] fields = line.Split(',');
            string prompt = fields[0];
            string response = fields[1];
            DateTime date = DateTime.Parse(fields[2]);
            Entry entry = new Entry(prompt, response, date);

            Entries.Add(entry);
        }

        reader.Close();
        Console.WriteLine($"Your journal has been loaded from {filename}.");
    }
}

