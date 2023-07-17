using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("--------Financial Reports Program---------");

        List<FinancialReport> reports = new List<FinancialReport>();

        while (true)
        {
            Console.WriteLine("\nChoose an option from the menu to start:");
            Console.WriteLine("1. Create budget");
            Console.WriteLine("2. Create financial report");
            Console.WriteLine("3. Display in spreadsheet");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Load");
            Console.WriteLine("6. Quit");

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CreateBudget(reports);
                    break;
                case 2:
                    CreateFinancialReport(reports);
                    break;
                case 3:
                    DisplayInSpreadsheet(reports);
                    break;
                case 4:
                    SaveReports(reports);
                    break;
                case 5:
                    LoadReports(reports);
                    break;
                case 6:
                    Console.WriteLine("Exiting...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void CreateBudget(List<FinancialReport> reports)
    {
        Console.WriteLine("\nChoose budget option:");
        Console.WriteLine("1. Weekly budget");
        Console.WriteLine("2. Monthly budget");

        Console.Write("Enter your choice: ");
        int choice = int.Parse(Console.ReadLine());

        FinancialReport budget = null;

        switch (choice)
        {
            case 1:
                budget = CreateWeeklyBudget();
                Console.WriteLine("Weekly budget created successfully.");
                break;
            case 2:
                budget = CreateMonthlyBudget();
                Console.WriteLine("Monthly budget created successfully.");
                break;
            default:
                Console.WriteLine("Invalid choice. Budget not created.");
                return;
        }

        if (budget != null)
        {
            reports.Add(budget);
        }
    }

    static FinancialReport CreateWeeklyBudget()
    {
        decimal[] income = new decimal[4];
        decimal[] expenses = new decimal[4];

        Console.WriteLine("\nEnter the income and expense values for each week:");

        for (int i = 0; i < 4; i++)
        {
            Console.Write($"Enter income for week {i + 1}: ");
            

            Console.Write($"Enter expenses for week {i + 1}: ");
            expenses[i] = decimal.Parse(Console.ReadLine());
        }

        return new WeeklyBudget(income, expenses);
    }

    static FinancialReport CreateMonthlyBudget()
    {
        decimal[] income = new decimal[12];
        decimal[] expenses = new decimal[12];

        Console.WriteLine("\nEnter the income and expense values for each month:");

        for (int i = 0; i < 12; i++)
        {
            Console.Write($"Enter income for month {i + 1}: ");
            income[i] = decimal.Parse(Console.ReadLine());

            Console.Write($"Enter expenses for month {i + 1}: ");
            expenses[i] = decimal.Parse(Console.ReadLine());
        }

        return new MonthlyBudget(income, expenses);
    }

    static void CreateFinancialReport(List<FinancialReport> reports)
    {
        Console.WriteLine("\nChoose financial report option:");
        Console.WriteLine("1. Profit and Loss Report");
        Console.WriteLine("2. Expenditures");
        Console.WriteLine("3. Expenditure Projection");
        Console.WriteLine("4. Profit Projection");

        Console.Write("Enter your choice: ");
        int choice = int.Parse(Console.ReadLine());

        FinancialReport report = null;

        switch (choice)
        {
            case 1:
                report = CreateProfitAndLossReport();
                Console.WriteLine("Profit and Loss Report created successfully.");
                break;
            case 2:
                report = CreateExpenditures();
                Console.WriteLine("Expenditures report created successfully.");
                break;
            case 3:
                report = CreateExpenditureProjection();
                Console.WriteLine("Expenditure Projection report created successfully.");
                break;
            case 4:
                report = CreateProfitProjection();
                Console.WriteLine("Profit Projection report created successfully.");
                break;
            default:
                Console.WriteLine("Invalid choice. Financial report not created.");
                return;
        }

        if (report != null)
        {
            reports.Add(report);
        }
    }

    static FinancialReport CreateProfitAndLossReport()
    {
        Console.Write("Enter total income: ");
        decimal income = decimal.Parse(Console.ReadLine());

        Console.Write("Enter total expenses: ");
        decimal expenses = decimal.Parse(Console.ReadLine());

        return new ProfitAndLossReport(income, expenses);
    }

    static FinancialReport CreateExpenditures()
    {
        decimal[] expenses = new decimal[2];

        Console.WriteLine("\nEnter the expenditure values for each week:");

        for (int i = 0; i < 2; i++)
        {
            Console.Write($"Enter expenditure for week {i + 1}: ");
            expenses[i] = decimal.Parse(Console.ReadLine());
        }

        return new Expenditures(expenses);
    }

    static FinancialReport CreateExpenditureProjection()
    {
        Console.Write("Enter average expense: ");
        decimal average = decimal.Parse(Console.ReadLine());

        Console.Write("Enter projected expense: ");
        decimal projected = decimal.Parse(Console.ReadLine());

        return new ExpenditureProjection(average, projected);
    }

    static FinancialReport CreateProfitProjection()
    {
        Console.Write("Enter average income: ");
        decimal average = decimal.Parse(Console.ReadLine());

        Console.Write("Enter projected income: ");
        decimal projected = decimal.Parse(Console.ReadLine());

        return new ProfitProjection(average, projected);
    }

    static void DisplayInSpreadsheet(List<FinancialReport> reports)
    {
        if (reports.Count == 0)
        {
            Console.WriteLine("No reports to display. Please create some reports first.");
            return;
        }

        Console.WriteLine("\nChoose report option to display in spreadsheet:");
        Console.WriteLine("1. Weekly budget");
        Console.WriteLine("2. Monthly budget");
        Console.WriteLine("3. Profit and Loss Report");
        Console.WriteLine("4. Expenditures");
        Console.WriteLine("5. Expenditure Projection");
        Console.WriteLine("6. Profit Projection");
        Console.WriteLine("7. All previous reports");

        Console.Write("Enter your choice: ");
        int choice = int.Parse(Console.ReadLine());

        Type reportType = null;

        switch (choice)
        {
            case 1:
                reportType = typeof(WeeklyBudget);
                break;
            case 2:
                reportType = typeof(MonthlyBudget);
                break;
            case 3:
                reportType = typeof(ProfitAndLossReport);
                break;
            case 4:
                reportType = typeof(Expenditures);
                break;
            case 5:
                reportType = typeof(ExpenditureProjection);
                break;
            case 6:
                reportType = typeof(ProfitProjection);
                break;
            case 7:
                DisplayAllReportsInSpreadsheet(reports);
                return;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                return;
        }

        DisplayReportsInSpreadsheet(reports, reportType);
    }

    static void DisplayReportsInSpreadsheet(List<FinancialReport> reports, Type reportType)
    {
        Console.WriteLine($"\nDisplaying {reportType.Name} Reports in Spreadsheet Format");
        Console.WriteLine("---------------------------------------");

        bool found = false;

        foreach (FinancialReport report in reports)
        {
            if (report.GetType() == reportType)
            {
                found = true;
                report.GenerateReport();
                Console.WriteLine();
            }
        }

        if (!found)
        {
            Console.WriteLine($"No {reportType.Name} reports found.");
        }
    }

    static void DisplayAllReportsInSpreadsheet(List<FinancialReport> reports)
    {
        Console.WriteLine("\nDisplaying All Reports in Spreadsheet Format");
        Console.WriteLine("---------------------------------------");

        foreach (FinancialReport report in reports)
        {
            Console.WriteLine();
            report.GenerateReport();
        }
    }

    static void SaveReports(List<FinancialReport> reports)
    {
        if (reports.Count == 0)
        {
            Console.WriteLine("No reports to save. Please create some reports first.");
            return;
        }

        Console.Write("Enter the file name to save: ");
        string fileName = Console.ReadLine();

        //using (StreamWriter writer = new StreamWriter(fileName))
        //{
        foreach (FinancialReport report in reports)
        {
            report.SaveToCSV(fileName);
        }
        //}

        Console.WriteLine("Reports saved successfully.");
    }

    static void LoadReports(List<FinancialReport> reports)
    {
        Console.Write("Enter the file name to load: ");
        string fileName = Console.ReadLine();

        if (File.Exists(fileName))
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] reportData = line.Split(',');

                    if (reportData.Length == 1)
                    {
                        int reportType = int.Parse(reportData[0]);
                        FinancialReport report;

                        switch (reportType)
                        {
                            case 1:
                                report = CreateWeeklyBudget();
                                break;
                            case 2:
                                report = CreateMonthlyBudget();
                                break;
                            case 3:
                                report = CreateProfitAndLossReport();
                                break;
                            case 4:
                                report = CreateExpenditures();
                                break;
                            case 5:
                                report = CreateExpenditureProjection();
                                break;
                            case 6:
                                report = CreateProfitProjection();
                                break;
                            default:
                                continue;
                        }

                        reports.Add(report);
                    }
                    else
                    {
                        int index = int.Parse(reportData[0]);
                        reports[index].LoadFromCSV(reportData[1]);
                    }
                }
            }

            Console.WriteLine("Reports loaded successfully.");
        }
        else
        {
            Console.WriteLine($"File {fileName} does not exist.");
        }
    }
}
