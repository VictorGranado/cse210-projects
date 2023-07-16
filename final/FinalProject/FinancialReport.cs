using System;

abstract class FinancialReport
{
    public abstract void GenerateReport();
    public abstract void SaveToCSV(string fileName);
    public abstract void LoadFromCSV(string fileName);

    internal void SaveToCSV(StreamWriter writer)
    {
        throw new NotImplementedException();
    }
}
