using System.Diagnostics;

public class ListingActivity : Activity
{

    private List<string> _prompts = new List<string> {"When is a time you felt the Holy Ghost today?"};
    public ListingActivity() : base("Listing Activity","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        
    }

    public void DoActivity()
    {
        Console.WriteLine("List as many answers to the following prompt as possible in the alloted time: ");
        Console.WriteLine($"---{_prompts[0]}---");
        Console.Write("You may begin in: ");

        _Countdown(5);

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        int responses = 0;

        while (DateTime.Now <= futureTime)
        {
            Console.ReadLine();

            responses++;
        }

        Console.WriteLine($"You made {responses} responses!");
    }
}