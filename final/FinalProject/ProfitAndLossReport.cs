using System;

class ProfitAndLossReport : FinancialReport
{
    private decimal totalIncome;
    private decimal totalExpenses;

    public ProfitAndLossReport(decimal income, decimal expenses)
    {
        totalIncome = income;
        totalExpenses = expenses;
    }

    public override void GenerateReport()
    {
        Console.WriteLine("Profit and Loss Report");
        Console.WriteLine("----------------------");
        Console.WriteLine($"Total Income: {totalIncome:C}");
        Console.WriteLine($"Total Expenses: {totalExpenses:C}");
        Console.WriteLine($"Net Profit: {totalIncome - totalExpenses:C}");
    }

    public override void SaveToCSV(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            writer.WriteLine($"{totalIncome},{totalExpenses}");
        }

        Console.WriteLine($"Profit and loss report saved to {fileName} successfully.");
    }

    public override void LoadFromCSV(string fileName)
    {
        if (File.Exists(fileName))
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line = reader.ReadLine();
                string[] values = line.Split(',');

                if (values.Length == 2 && decimal.TryParse(values[0], out decimal income) && decimal.TryParse(values[1], out decimal expenses))
                {
                    totalIncome = income;
                    totalExpenses = expenses;
                }
            }

            Console.WriteLine($"Profit and loss report loaded from {fileName} successfully.");
        }
        else
        {
            Console.WriteLine($"File {fileName} does not exist.");
        }
    }
}
