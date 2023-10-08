// A class to represent a journal
class Journal
{
    public List<Entry> Entries { get; set; } // A list of entries in the journal

    // A constructor that creates an empty journal
    public Journal()
    {
        Entries = new List<Entry>();
    }

    // A method to add a new entry to the journal
    public void WriteEntry()
    {
        // A list of prompts that can be randomly chosen
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

        // Choose a random prompt from the list
        Random random = new Random();
        int index = random.Next(prompts.Length);
        string prompt = prompts[index];

        // Display the prompt and ask the user to write a response
        Console.WriteLine($"Your prompt for today is: {prompt}");
        Console.WriteLine("Please write your response below:");
        string response = Console.ReadLine();

        // Create a new entry with the current date and time
        DateTime date = DateTime.Now;
        Entry entry = new Entry(prompt, response, date);

        // Add the entry to the journal
        Entries.Add(entry);

        // Display a confirmation message
        Console.WriteLine("Your entry has been saved.");
    }

    // A method to display all the entries in the journal
    public void DisplayJournal()
    {
        // Check if the journal is empty
        if (Entries.Count == 0)
        {
            Console.WriteLine("Your journal is empty.");
            return;
        }

        // Display each entry in the journal
        Console.WriteLine("Your journal entries are:");
        foreach (Entry entry in Entries)
        {
            entry.Display();
        }
    }

    // A method to save the journal to a file
    public void SaveToFile()
    {
        // Ask the user for a filename
        Console.WriteLine("Please enter a filename to save your journal:");
        string filename = Console.ReadLine();

        // Create a stream writer object to write to the file
        StreamWriter writer = new StreamWriter(filename);

        // Write each entry in the journal to the file in a CSV format
        foreach (Entry entry in Entries)
        {
            writer.WriteLine($"{entry.Prompt},{entry.Response},{entry.Date}");
        }

        // Close the stream writer object and display a confirmation message
        writer.Close();
        Console.WriteLine($"Your journal has been saved to {filename}.");
    }

    // A method to load the journal from a file
    public void LoadFromFile()
    {
        // Ask the user for a filename
        Console.WriteLine("Please enter a filename to load your journal:");
        string filename = Console.ReadLine();

        // Check if the file exists
        if (!File.Exists(filename))
        {
            Console.WriteLine($"The file {filename} does not exist.");
            return;
        }

        // Create a stream reader object to read from the file
        StreamReader reader = new StreamReader(filename);

        // Clear the current entries in the journal
        Entries.Clear();

        // Read each line from the file and create an entry from it
        while (!reader.EndOfStream)
        {
            string line = reader.ReadLine();
            string[] fields = line.Split(',');
            string prompt = fields[0];
            string response = fields[1];
            DateTime date = DateTime.Parse(fields[2]);
            Entry entry = new Entry(prompt, response, date);

            // Add the entry to the journal
            Entries.Add(entry);
        }

        // Close the stream reader object and display a confirmation message
        reader.Close();
        Console.WriteLine($"Your journal has been loaded from {filename}.");
    }
}

