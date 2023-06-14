using System;

namespace Develop04
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We live in a fast-paced world full of stress and anxiety. We could each benefit from taking time for mindfulness activities where we can reflect and unwind.");

            string input;

            while (true)
            {
                Console.WriteLine("\nSelect an activity:");
                Console.WriteLine("1. Breathing");
                Console.WriteLine("2. Reflection");
                Console.WriteLine("3. Listing");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice (1-4): ");
                input = Console.ReadLine();

                int choice;
        if (int.TryParse(input, out choice))
        {
            switch (choice)
            {
                case 1:
                    Activities breathingActivity = new Breathing();
                    Console.Write("Enter the duration (in seconds): ");
                    if (int.TryParse(Console.ReadLine(), out int duration))
                    {
                        breathingActivity.duration = duration;
                        breathingActivity.StartActivity();
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid duration.");
                    }
                    break;

                case 2:
                    Activities reflectionActivity = new Reflection();
                    Console.Write("Enter the duration (in seconds): ");
                    if (int.TryParse(Console.ReadLine(), out duration))
                    {
                        reflectionActivity.duration = duration;
                        reflectionActivity.StartActivity();
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid duration.");
                    }
                    break;

                case 3:
                    Activities listingActivity = new Listing();
                    Console.Write("Enter the duration (in seconds): ");
                    if (int.TryParse(Console.ReadLine(), out duration))
                    {
                        listingActivity.duration = duration;
                        listingActivity.StartActivity();
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid duration.");
                    }
                    break;

                case 4:
                    return;

                default:
                    Console.WriteLine("Invalid input. Please enter a valid choice.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid choice.");
        }

                Console.WriteLine();
            }
        }
    }
}
