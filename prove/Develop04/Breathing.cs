using System;
using System.Threading;

namespace Develop04
{
    public class Breathing : Activities
    {
        public override void StartActivity()
        {
            StartMessage(duration);

            Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
            Thread.Sleep(5000);
            Console.WriteLine();

            int breathCount = duration / 8;
            int breathIndex = 0;
            while (breathIndex < breathCount)
            {
                Console.WriteLine("Breathe in...");
                Thread.Sleep(4000);
                Console.WriteLine("Breathe out...");
                Thread.Sleep(4000);
                breathIndex++;
            }

            Console.Clear();
            EndMessage(duration);
            LogData("Breathing Activity", duration);
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
            Console.WriteLine("--- Breathing Activity ---");
            Console.WriteLine("Great job! You have completed the activity.");
            Console.WriteLine("Duration: " + duration + " seconds");
            Thread.Sleep(5000);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}

