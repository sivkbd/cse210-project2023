class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.") { }

    protected override void Run()
    {
        for (int i = 0; i < Duration; i++)
        {
            if (i % 2 == 0)
                Console.WriteLine("Breathe in...");
            else
                Console.WriteLine("Breathe out...");

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
                Thread.Sleep(3000);
                Console.Write("\b \b");

            }

        }
    }
}

