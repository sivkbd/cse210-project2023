class ListingActivity : Activity
{
    private string[] prompts = new string[]
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.") { }

    protected override void Run()
    {
        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Length)];

        Console.WriteLine(prompt);
        Thread.Sleep(3000);

        for (int i = 0; i < Duration; i++)
        {
            Console.WriteLine("List an item...");
            Thread.Sleep(20000);
        }
        
    }
}
