using System;

class Program
{
    static void Main(string[] args)
    {
        DateTime dateValue = DateTime.Now;
        
        List<Activity> aList = new List<Activity>();

        Activity a1 = new Running(10, dateValue, 90);
        aList.Add(a1);

        Activity a2 = new Swimming(25, dateValue, 80);
        aList.Add(a2);

        Activity a3 = new Cycling(35, dateValue, 90);
        aList.Add(a3);

        foreach (Activity a in aList)
        {
            string summaryString = a.GetSummary();
            Console.WriteLine(summaryString);
        }
    }
}