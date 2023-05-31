using System;
using System.Collections.Generic;
using System.IO;
 
class Loader
{
    private Dictionary<string, string> csvData;

    public Loader(string filePath)
    {
        csvData = new Dictionary<string, string>();
        LoadCSV(filePath);
    }

    private void LoadCSV(string filePath)
    {
        try
        {
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length >= 2)
                {
                    string key = parts[0];
                    string value = parts[1];
                    csvData[key] = value;
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found: " + filePath);
        }
    }

    public string FindRandomScripture()
    {
        if (csvData.Count == 0)
        {
            Console.WriteLine("No data available.");
            return null;
        }

        Random random = new Random();
        int index = random.Next(0, csvData.Count);
        KeyValuePair<string, string> randomEntry = csvData.ElementAt(index);
        return randomEntry.Key + ": " + randomEntry.Value;
    }
}

    
    