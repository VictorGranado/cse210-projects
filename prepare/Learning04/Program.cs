using System;

namespace Learning04
{
    class Program
    {
        static void Main(string[] args)
        {
             // Create a MathAssignment
        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        string mathSummary = mathAssignment.GetSummary();
        string mathHomeworkList = mathAssignment.GetHomeworkList();

        Console.WriteLine(mathSummary);
        Console.WriteLine(mathHomeworkList);
        Console.WriteLine();

        // Create a WritingAssignment
        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "Causes of World War II");
        string writingSummary = writingAssignment.GetSummary();
        string writingInformation = writingAssignment.GetWritingInformation();

        Console.WriteLine(writingSummary);
        Console.WriteLine(writingInformation);

        Console.ReadLine();
        }
    }
}