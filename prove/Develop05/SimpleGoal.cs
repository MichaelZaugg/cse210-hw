using System;

public class SimpleGoal : Goal 
{
    private bool Complete;

    public SimpleGoal(string name, string description, string points, bool isComplete=false) : base(name, description, points)
    {

        this.Complete = isComplete;
    }

    public override void RecordEvent()
    {
        this.Complete = true;


    }

    public override bool IsComplete()
    {
        return Complete;
    }

    public override string GetStringRepresentation()
    {
        string representation = $"SimpleGoal:{base.GetName()},{base.GetDescription()},{base.GetPoints()},{Complete}";

        return representation;
    }

  
}