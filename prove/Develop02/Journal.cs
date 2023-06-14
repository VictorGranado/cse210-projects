using System;
using System.Collections.Generic;
using System.IO;
 
namespace Develop02
{
    public class Journal
    {
        private List<Entry> entries;  // A list to store all the journal entries

        public Journal()
        {
            entries = new List<Entry>();
        }

        public void AddEntry(string prompt, string response)
        {
            Entry entry = new Entry
            {
                Prompt = prompt,
                Response = response,
                Date = DateTime.Now  // Set the current date and time as the entry creation time
            };
            entries.Add(entry);  // Add the entry to the list of entries
        }

        public void DisplayJournal()
        {
            foreach (Entry entry in entries)
            {
                Console.WriteLine($"Prompt: {entry.Prompt}");  // Display the prompt for the entry
                Console.WriteLine($"Response: {entry.Response}");  // Display the user's response
                Console.WriteLine($"Date: {entry.Date}\n");  // Display the date and time of the entry
            }
        }

        public void SaveJournalToFile(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (Entry entry in entries)
                {
                    writer.WriteLine($"Prompt: {entry.Prompt}");  // Write the prompt to the file
                    writer.WriteLine($"Response: {entry.Response}");  // Write the response to the file
                    writer.WriteLine($"Date: {entry.Date}\n");  // Write the date and time to the file
                }
            }
        }

        public void LoadJournalFromFile(string fileName)
        {
            entries.Clear();  // Clear the existing entries before loading from file
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string prompt = line.Substring(line.IndexOf(":") + 1).Trim();  // Extract the prompt from the line
                    string response = reader.ReadLine().Substring(line.IndexOf(":") + 1).Trim();  // Extract the response from the line
                    DateTime date = DateTime.Parse(reader.ReadLine().Substring(line.IndexOf(":") + 1).Trim());  // Extract the date from the line and parse it to DateTime
                    Entry entry = new Entry
                    {
                        Prompt = prompt,
                        Response = response,
                        Date = date
                    };
                    entries.Add(entry);  // Add the entry to the list of entries
                }
            }
        }
    }
}