using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbersList = new List<int>() { };

        string userNumber = " ";
        int trueNumber = -1;
        int sum = 0;

        while (trueNumber != 0)
        {
            Console.Write("Add a number ");
            userNumber = Console.ReadLine();
            trueNumber = int.Parse(userNumber);

            if (trueNumber != 0)
            {
                numbersList.Add(trueNumber);
            }
        }

        for (int i = 0; i < numbersList.Count; i++)
        {
            sum += numbersList[i];
        }

        Console.WriteLine($"The sum of all values in the list is {sum}");

        int average = sum / numbersList.Count;
        Console.WriteLine($"The average value of the list is {average}");

        int max = numbersList[0];

        for (int i = 1; i < numbersList.Count; i++)
        {
            if (numbersList[i] > max)
            {
                max = numbersList[i];
            }
        }

        Console.WriteLine($"The maximum value in the list is {max}");

    }
}