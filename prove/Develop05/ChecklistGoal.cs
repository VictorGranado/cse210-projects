using System;

namespace Develop05
{
    public class ChecklistGoal : Goal
{
    public int ItemCount { get; }
    public int CompletedCount { get; set; }

    public ChecklistGoal(string name, string description, int itemCount) : base(name, description)
    {
        ItemCount = itemCount;
        CompletedCount = 0;
    }

    public override void Complete()
    {
        CompletedCount++;

        if (CompletedCount == ItemCount)
        {
            Points = ItemCount * 20 + ItemCount * 10;
        }
        else
        {
            Points = CompletedCount * 20;
        }

        Completed = true;
    }
}

}