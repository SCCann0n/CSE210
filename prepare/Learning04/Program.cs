using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("John Doe", "Physics");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment mathAssignment = new MathAssignment("John Doe", "Math", "Section 1.1", "Problem 7");
        Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignment writingAssignment = new WritingAssignment("John Doe", "Writing", "Hamlet");
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}