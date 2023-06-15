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
            // Initialize the prompts list and set up other variables
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
            // Display the start message for the listing activity
            StartMessage(duration);

            Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
            LoadSpinner(5);
            Console.WriteLine();

            Console.WriteLine("Prompt: " + SelectRandomPrompt());
            Console.WriteLine();
            Console.WriteLine("You have " + duration + " seconds to list as many items as you can...");
            Console.WriteLine("Press Enter after each item.");

            // Start a separate thread to read user input
            Thread inputThread = new Thread(ReadInput);
            inputThread.Start();

            // Wait for the specified duration
            Thread.Sleep(duration * 1000);

            // Set the flag to indicate that input collection is finished
            inputFinished = true;

            // Wait for the input thread to complete
            inputThread.Join();

            Console.Clear();

            // Display the end message for the listing activity
            EndMessage(duration);

            // Log the activity data
            LogData("Listing Activity", items.Count);
        }

        protected override void StartMessage(int duration)
        {
            Console.WriteLine("Duration: " + duration + " seconds");
            Console.WriteLine("Prepare to begin...");
            LoadSpinner(5);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }

        protected override void EndMessage(int duration)
        {
            Console.WriteLine("--- Listing Activity ---");
            Console.WriteLine("Great job! You have completed the activity.");
            Console.WriteLine("Number of items listed: " + items.Count);
            LoadSpinner(5);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }

        private void ReadInput()
        {
            // Read user input until inputFinished is set to true
            while (!inputFinished)
            {
                string input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                    continue;

                // Add the input item to the list
                items.Add(input);
            }
        }

        private string SelectRandomPrompt()
        {
            // Select a random prompt from the prompts list
            Random random = new Random();
            int index = random.Next(prompts.Count);
            return prompts[index];
        }
    }
}

