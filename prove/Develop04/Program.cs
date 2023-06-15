using System;

namespace Develop04
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Display an introductory message
            Console.WriteLine("We live in a fast-paced world full of stress and anxiety. We could each benefit from taking time for mindfulness activities where we can reflect and unwind.");

            string input;

            // Keep looping until the user chooses to exit
            while (true)
            {
                // Display the menu options
                Console.WriteLine("\nSelect an activity:");
                Console.WriteLine("1. Breathing");
                Console.WriteLine("2. Reflection");
                Console.WriteLine("3. Listing");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice (1-4): ");
                input = Console.ReadLine();

                int choice;

                // Check if the user's input is a valid integer
                if (int.TryParse(input, out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            // Create a new instance of the Breathing activity
                            Activities breathingActivity = new Breathing();
                            Console.Write("Enter the duration (in seconds): ");
                            
                            // Check if the user's input for duration is a valid integer
                            if (int.TryParse(Console.ReadLine(), out int duration))
                            {
                                breathingActivity.duration = duration;
                                // Start the breathing activity
                                breathingActivity.StartActivity();
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter a valid duration.");
                            }
                            break;

                        case 2:
                            // Create a new instance of the Reflection activity
                            Activities reflectionActivity = new Reflection();
                            Console.Write("Enter the duration (in seconds): ");
                            
                            // Check if the user's input for duration is a valid integer
                            if (int.TryParse(Console.ReadLine(), out duration))
                            {
                                reflectionActivity.duration = duration;
                                // Start the reflection activity
                                reflectionActivity.StartActivity();
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter a valid duration.");
                            }
                            break;

                        case 3:
                            // Create a new instance of the Listing activity
                            Activities listingActivity = new Listing();
                            Console.Write("Enter the duration (in seconds): ");
                            
                            // Check if the user's input for duration is a valid integer
                            if (int.TryParse(Console.ReadLine(), out duration))
                            {
                                listingActivity.duration = duration;
                                // Start the listing activity
                                listingActivity.StartActivity();
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter a valid duration.");
                            }
                            break;

                        case 4:
                            // Exit the program
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

