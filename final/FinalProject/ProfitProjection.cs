using System;

namespace FinalProject
{
    class ProfitProjection : FinancialReport
    {
        private decimal averageIncome;
        private decimal projectedIncome;

        public ProfitProjection(decimal average, decimal projected)
        {
            averageIncome = average;
            projectedIncome = projected;
        }

        public override void GenerateReport()
        {
            Console.WriteLine("Profit Projection Report");
            Console.WriteLine("------------------------");
            Console.WriteLine($"Average Income: {averageIncome:C}");
            Console.WriteLine($"Projected Income: {projectedIncome:C}");
        }

        public override void SaveToCSV(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine($"{averageIncome},{projectedIncome}");
            }

            Console.WriteLine($"Profit projection report saved to {fileName} successfully.");
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
                        averageIncome = average;
                        projectedIncome = projected;
                    }
                }

                Console.WriteLine($"Profit projection report loaded from {fileName} successfully.");
            }
            else
            {
                Console.WriteLine($"File {fileName} does not exist.");
            }
        }
    }
}