using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Electrical Engineer";
        job1._company = "Amazon";
        job1._startYear = 2008;
        job1._endYear = 2020;

        Job job2 = new Job();
        job2._jobTitle = "Mechanical Engineer";
        job2._company = "Tesla";
        job2._startYear = 2020;
        job2._endYear = 2025;

        job1.Display();
        job2.Display();

        Resume resume1 = new Resume();

        resume1._name = "Seth Cannon";

        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.Display();
    }
}