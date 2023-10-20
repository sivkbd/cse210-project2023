abstract class Activity
{
    protected string Name;
    protected string Description;
    protected int Duration;

    public Activity(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public void Start()
    {
        Console.WriteLine($"Welcome to {Name} Activity");
        Console.WriteLine(Description);
        Console.WriteLine("Enter the duration of the activity in seconds:");
        Duration = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Get ready to begin...");
        List<string>animationStrings = new List<string>();
            animationStrings.Add("|");
            animationStrings.Add("/");
            animationStrings.Add("-");
            animationStrings.Add("\\");
            animationStrings.Add("|");
            animationStrings.Add("/");
            animationStrings.Add("-");
            animationStrings.Add("\\");

            foreach ( string a in animationStrings){
                Console.Write(a);
                Thread.Sleep(1000);
                Console.Write("\b \b");

            }


        Run();

        End();
    }

    protected abstract void Run();

    private void End()
    {
        Console.WriteLine("Good job!");
        Thread.Sleep(10000);
        Console.WriteLine($"You have completed the {Name} activity for {Duration} seconds.");
    }
}

