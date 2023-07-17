using System;

namespace FinalProject
{
    class DisplayInSheets : FinancialReport
    {
        private FinancialReport[] reports;

        public DisplayInSheets(FinancialReport[] reports)
        {
            this.reports = reports;
        }

        public override void GenerateReport()
        {
            Console.WriteLine("Displaying Reports in Spreadsheet Format");
            Console.WriteLine("---------------------------------------");

            foreach (FinancialReport report in reports)
            {
                Console.WriteLine();
                report.GenerateReport();
            }
        }

        public override void SaveToCSV(string fileName)
        {
            Console.WriteLine("Saving Reports to CSV");
            Console.WriteLine("---------------------");

            foreach (FinancialReport report in reports)
            {
                Console.WriteLine();
                report.SaveToCSV(fileName);
            }
        }

        public override void LoadFromCSV(string fileName)
        {
            Console.WriteLine("Loading Reports from CSV");
            Console.WriteLine("------------------------");

            foreach (FinancialReport report in reports)
            {
                Console.WriteLine();
                report.LoadFromCSV(fileName);
            }
        }
    }
}