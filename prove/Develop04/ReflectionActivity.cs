using System.Diagnostics;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>{"Think of a time when you did something really difficult", "Think of an experience that changed you for the better"};

    private List<string> _reflectionQuestions = new List<string> { "How did you feel when it was complete? ", "What did you feel about this experience?" };


    public ReflectionActivity() : base("Reflection Activity", "This activity will help you to reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
     
    }
    public void DoActivity()
    {

        Console.WriteLine("\nConsider the following prompt:\n");
        Console.WriteLine($"---{_prompts[0]}---");
        Console.WriteLine("Press enter to continue: ");

        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience. ");

        Console.Write("You may begin in: ");

        _Countdown(5);

        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        Random random = new Random();

        int i = random.Next(0, _reflectionQuestions.Count());

        while (DateTime.Now <= futureTime)
        {
            Console.WriteLine($"{_reflectionQuestions[i]}");

            i = random.Next(0, _reflectionQuestions.Count());

            _SpinnerAnimation(10);
        }

    }
}