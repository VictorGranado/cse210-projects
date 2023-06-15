using System;
using System.Collections.Generic;
using System.Threading;

namespace Develop04
{
    public class Reflection : Activities
    {
        private List<string> prompts;
        private List<string> questions;

        public Reflection()
        {
            // Initialize the prompts and questions lists
            prompts = new List<string>()
            {
                "Think of a time when you stood up for someone else.",
                "Think of a time when you did something really difficult.",
                "Think of a time when you helped someone in need.",
                "Think of a time when you did something truly selfless."
            };

            questions = new List<string>()
            {
                "Why was this experience meaningful to you?",
                "Have you ever done anything like this before?",
                "How did you get started?",
                "How did you feel when it was complete?",
                "What made this time different than other times when you were not as successful?",
                "What is your favorite thing about this experience?",
                "What could you learn from this experience that applies to other situations?",
                "What did you learn about yourself through this experience?",
                "How can you keep this experience in mind in the future?"
            };
        }

        public override void StartActivity()
        {
            // Display the start message for the reflection activity
            StartMessage(duration);

            Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
            LoadSpinner(5);
            Console.WriteLine();

            Random random = new Random();

            // Calculate the number of questions based on the duration of the activity
            int questionCount = duration / 8;
            int questionIndex = 0;

            // Perform the reflection activity
            while (questionIndex < questionCount)
            {
                Console.WriteLine("Prompt: " + SelectRandomPrompt(random));
                Console.WriteLine();

                foreach (string question in questions)
                {
                    Console.WriteLine("Question: " + question);
                    Thread.Sleep(3000);
                }

                questionIndex++;
            }

            Console.Clear();

            // Display the end message for the reflection activity
            EndMessage(duration);

            // Log the activity data
            LogData("Reflection Activity", duration);
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
            Console.WriteLine("--- Reflection Activity ---");
            Console.WriteLine("Great job! You have completed the activity.");
            Console.WriteLine("Duration: " + duration + " seconds");
            LoadSpinner(5);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }

        private string SelectRandomPrompt(Random random)
        {
            int index = random.Next(prompts.Count);
            return prompts[index];
        }
    }
}

