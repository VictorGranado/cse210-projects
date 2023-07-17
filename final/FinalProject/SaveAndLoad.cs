using System;
using System.IO;

class SaveAndLoad : FinancialReport
{
    private string reportData;

    public SaveAndLoad(string data)
    {
        reportData = data;
    }

    public override void GenerateReport()
    {
        Console.WriteLine("Save and Load Report Data");
        Console.WriteLine("-------------------------");

        // Code for saving and loading report data
    
    }

    public override void SaveToCSV(string fileName)
    {
        try
        {
            File.WriteAllText(fileName, reportData);
            Console.WriteLine($"Report data saved to {fileName} successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving the report data: {ex.Message}");
        }
    }

    public override void LoadFromCSV(string fileName)
    {
        try
        {
            if (File.Exists(fileName))
            {
                reportData = File.ReadAllText(fileName);
                Console.WriteLine($"Report data loaded from {fileName} successfully.");
            }
            else
            {
                Console.WriteLine($"File {fileName} does not exist.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading the report data: {ex.Message}");
        }
    }
}
