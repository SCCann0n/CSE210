using System.Diagnostics;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {

    }
    
    public void DoActivity()
    {
        

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        int breatheIn = 2;

        int breatheOut = 3;

        while (DateTime.Now <= futureTime)
        {
            Console.Write("\nBreathe in... ");
            _Countdown(breatheIn);

            Console.Write("\nBreathe out...");
            _Countdown(breatheOut);

            Console.WriteLine();


            breatheIn = breatheIn + 1;
            breatheOut = breatheOut + 2;

        }

    }
}