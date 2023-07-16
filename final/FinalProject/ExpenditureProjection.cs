using System;

class ExpenditureProjection : FinancialReport
{
    private decimal averageExpense;
    private decimal projectedExpense;

    public ExpenditureProjection(decimal average, decimal projected)
    {
        averageExpense = average;
        projectedExpense = projected;
    }

    public override void GenerateReport()
    {
        Console.WriteLine("Expenditure Projection Report");
        Console.WriteLine("----------------------------");
        Console.WriteLine($"Average Expense: {averageExpense:C}");
        Console.WriteLine($"Projected Expense: {projectedExpense:C}");
    }

    public override void SaveToCSV(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            writer.WriteLine($"{averageExpense},{projectedExpense}");
        }

        Console.WriteLine($"Expenditure projection report saved to {fileName} successfully.");
    }

    public override void LoadFromCSV(string fileName)
    {
        if (File.Exists(fileName))
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line = reader.ReadLine();
                string[] values = line.Split(',');

                if (values.Length == 2 && decimal.TryParse(values[0], out decimal average) && decimal.TryParse(values[1], out decimal projected))
                {
                    averageExpense = average;
                    projectedExpense = projected;
                }
            }

            Console.WriteLine($"Expenditure projection report loaded from {fileName} successfully.");
        }
        else
        {
            Console.WriteLine($"File {fileName} does not exist.");
        }
    }
}
