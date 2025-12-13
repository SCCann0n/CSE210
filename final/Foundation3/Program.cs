using System;

class Program
{
    static void Main(string[] args)
    {
        List<Event> eList = new(); 

        for (int i = 0; i<3; i++)
        {
            switch (i)
            {
                case 0:
                    Event exLecture = new Lecture("Ted Talk", "Brain Health", DateTime.Now, new Address("55 North", "Jonestown", "New Hampshire", "United States", "56293"), "Dr. Goodwin", 10000);
                    eList.Add(exLecture);
                    break;
                case 1:
                    Event exOutdoor = new Outdoor("Concert", "Pop Music", DateTime.Now, new Address("The Dunes", "Beaverton", "Colorado", "United States", "24321"), "Partly Cloudy");
                    eList.Add(exOutdoor);
                    break;
                case 2:
                    Event exReception = new Reception("Wedding", "David and Kate's Wedding", DateTime.Now, new Address("15 Beach Ave", "San Diego", "California", "United States", "22517"), true, "DavidKate2025@gmail.com");
                    eList.Add(exReception);
                    break;
            }
        }

        foreach (Event e in eList)
        {
            Console.WriteLine(e.StandardDetails());
            Console.WriteLine(e.FullDetails());
            Console.WriteLine(e.ShortDescription());
        }


    }
}