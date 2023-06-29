using System;

namespace Develop05
{
    public class EternalGoal : Goal
{
    public EternalGoal(string name, string description) : base(name, description)
    {
        Points = 100;
    }

    public override void Complete()
    {
        Points += 100;
    }
}

}