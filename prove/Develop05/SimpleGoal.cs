using System;

namespace Develop05
{
    public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description) : base(name, description)
    {
        Points = 50;
    }

    public override void Complete()
    {
        if (!Completed)
        {
            Completed = true;
        }
    }
}

}