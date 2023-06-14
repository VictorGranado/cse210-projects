using System;
using System.Collections.Generic;
using System.Threading;

namespace Develop04
{
    public class Listing : Activities
    {
        private List<string> prompts;
    private List<string> items;
    private bool inputFinished;

    public Listing()
    {
        prompts = new List<string>()
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        items = new List<string>();
        inputFinished = false;
    }

    public override void StartActivity()
    {
        StartMessage(duration);

        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        Thread.Sleep(5000);
        Console.WriteLine();

        Console.WriteLine("Prompt: " + SelectRandomPrompt());
        Console.WriteLine();
        Console.WriteLine("You have " + duration + " seconds to list as many items as you can...");
        Console.WriteLine("Press Enter after each item.");

        Thread inputThread = new Thread(ReadInput);
        inputThread.Start();
        Thread.Sleep(duration * 1000);

        inputFinished = true;
        inputThread.Join();

        Console.Clear();
        EndMessage(duration);
        LogData("Listing Activity", items.Count);
    }

    protected override void StartMessage(int duration)
    {
        Console.WriteLine("Duration: " + duration + " seconds");
        Console.WriteLine("Prepare to begin...");
        Thread.Sleep(5000);
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
        Console.Clear();
    }

    protected override void EndMessage(int duration)
    {
        Console.WriteLine("--- Listing Activity ---");
        Console.WriteLine("Great job! You have completed the activity.");
        Console.WriteLine("Number of items listed: " + items.Count);
        Thread.Sleep(5000);
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
        Console.Clear();
    }

    private void ReadInput()
    {
        while (!inputFinished)
        {
            string input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
                continue;

            items.Add(input);
        }
    }

    private string SelectRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }
    }
}
