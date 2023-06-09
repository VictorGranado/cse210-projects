using System;

namespace Develop04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Activity Program!");

            int duration;
            do
            {
                Console.Write("Enter the duration for the activity in seconds: ");
            } while (!int.TryParse(Console.ReadLine(), out duration));

            Breathing breathing = new Breathing(duration);
            Reflection reflection = new Reflection(duration);
            Listing listing = new Listing(duration);

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\nSelect an activity:");
                Console.WriteLine("1. Breathing Activity");
                Console.WriteLine("2. Reflection Activity");
                Console.WriteLine("3. Listing Activity");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your choice (1-4): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        breathing.StartBreathingActivity();
                        break;
                    case "2":
                        reflection.StartReflectionActivity();
                        break;
                    case "3":
                        listing.StartListingActivity();
                        break;
                    case "4":
                        exit = true;
                        Console.WriteLine("Exiting the program...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
