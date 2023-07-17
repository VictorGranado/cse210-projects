using System;
using System.IO;
namespace FinalProject
{
    class Expenditures : FinancialReport
    {
        private decimal[] expenditureValues;

        public Expenditures(decimal[] expenditures)
        {
            expenditureValues = expenditures;
        }

        public override void GenerateReport()
        {
            Console.WriteLine("Expenditures Report");
            Console.WriteLine("-------------------");
            Console.WriteLine("Week\tExpenditure");
            Console.WriteLine("-------------------");

            for (int i = 0; i < expenditureValues.Length; i++)
            {
                Console.WriteLine($"{i + 1}\t{expenditureValues[i]:C}");
            }
        }

        public override void SaveToCSV(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                for (int i = 0; i < expenditureValues.Length; i++)
                {
                    writer.WriteLine($"{expenditureValues[i]}");
                }
            }

            Console.WriteLine($"Expenditures report saved to {fileName} successfully.");
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
                        if (decimal.TryParse(line, out decimal expenditure))
                        {
                            expenditureValues[index] = expenditure;
                            index++;
                        }
                    }
                }

                Console.WriteLine($"Expenditures report loaded from {fileName} successfully.");
            }
            else
            {
                Console.WriteLine($"File {fileName} does not exist.");
            }
        }
    }
}