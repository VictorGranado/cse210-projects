using System;

namespace Develop02
{
    public class Program
    {
        static Journal journal = new Journal();  // Create an instance of the Journal class.

        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("1. Write a new entry");
                Console.WriteLine("2. Display the journal");
                Console.WriteLine("3. Save the journal to a file");
                Console.WriteLine("4. Load the journal from a file");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        WriteNewEntry();
                        break;
                    case "2":
                        DisplayJournal();
                        break;
                    case "3":
                        SaveJournal();
                        break;
                    case "4":
                        LoadJournal();
                        break;
                    case "5":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.\n");
                        break;
                }
            }
        }

        static void WriteNewEntry()
        {
            string[] prompts = {
                "Who was the most interesting person I interacted with today?",
                "What was the best part of my day?",
                "How did I see the hand of the Lord in my life today?",
                "What was the strongest emotion I felt today?",
                "If I had one thing I could do over today, what would it be?"
            };

            Random random = new Random();
            int index = random.Next(prompts.Length);
            string prompt = prompts[index];

            Console.WriteLine($"Prompt: {prompt}");
            Console.Write("Enter your response: ");
            string response = Console.ReadLine();

            journal.AddEntry(prompt, response);  // Add the new entry to the journal
            Console.WriteLine("Entry added.\n");
        }

        static void DisplayJournal()
        {
            journal.DisplayJournal();  // Display all the entries in the journal
        }

        static void SaveJournal()
        {
            Console.Write("Enter a filename to save the journal: ");
            string fileName = Console.ReadLine();
            journal.SaveJournalToFile(fileName);  // Save the journal to the specified file
            Console.WriteLine("Journal saved.\n");
        }

        static void LoadJournal()
        {
            Console.Write("Enter a filename to load the journal: ");
            string fileName = Console.ReadLine();
            journal.LoadJournalFromFile(fileName);  // Load the journal from the specified file
            Console.WriteLine("Journal loaded.\n");
        }
    }
}
