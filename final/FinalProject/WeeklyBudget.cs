using System;
using System.IO;

namespace FinalProject
{
    class WeeklyBudget : FinancialReport
    {
        private decimal[] incomeValues;
        private decimal[] expenseValues;

        public WeeklyBudget(decimal[] income, decimal[] expenses)
        {
            incomeValues = income;
            expenseValues = expenses;
        }

        public override void GenerateReport()
        {
            Console.WriteLine("Weekly Budget Report");
            Console.WriteLine("---------------------");
            Console.WriteLine("Income\t\tExpenses");
            Console.WriteLine("---------------------");

            for (int i = 0; i < incomeValues.Length; i++)
            {
                Console.WriteLine($"{incomeValues[i]:C}\t{expenseValues[i]:C}");
            }
        }

        public override void SaveToCSV(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                for (int i = 0; i < incomeValues.Length; i++)
                {
                    writer.WriteLine($"{incomeValues[i]},{expenseValues[i]}");
                }
            }

            Console.WriteLine($"Weekly budget report saved to {fileName} successfully.");
        }

        public override void LoadFromCSV(string fileName)
        {
            if (File.Exists(fileName))
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    string line;
                    int index = 0;

                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] values = line.Split(',');
                        if (values.Length == 2 && decimal.TryParse(values[0], out decimal income) && decimal.TryParse(values[1], out decimal expense))
                        {
                            incomeValues[index] = income;
                            expenseValues[index] = expense;
                            index++;
                        }
                    }
                }

                Console.WriteLine($"Weekly budget report loaded from {fileName} successfully.");
            }
            else
            {
                Console.WriteLine($"File {fileName} does not exist.");
            }
        }
    }
}