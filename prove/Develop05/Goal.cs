using System;

namespace Develop05
{
    public abstract class Goal
{
    public string Name { get; }
    public string Description { get; }
    public int Points { get; protected set; }
    public bool Completed { get; protected set; }

    public Goal(string name, string description)
    {
        Name = name;
        Description = description;
        Points = 0;
        Completed = false;
    }

    public abstract void Complete();

        internal ReadOnlySpan<char> Serialize()
        {
            throw new NotImplementedException();
        }

        internal static Goal Deserialize(string line)
        {
            throw new NotImplementedException();
        }
    }

}