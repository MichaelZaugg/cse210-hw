using System;



public class ChecklistGoal : Goal 
{

    protected int  amountCompleted;

    private int target;

    private int bonus;

    public ChecklistGoal(string name, string description, string points,int target, int bonus) : base(name, description, points)
    {
        this.target = target;
        this.bonus = bonus;
        this.amountCompleted = 0;
    }


    public override void RecordEvent()
    {
       amountCompleted++;

       if (target == amountCompleted)
       {
        int totalPoints = GetPoints() + bonus;
        SetPoints(totalPoints);
       }
       
    }

    public override bool IsComplete()
    {
        if (amountCompleted == target)
        {
           
            return true;
        
        } else

        {

        return false;
        }
    }

    public override string GetStringRepresentation()
    {
        string representation = $"ChecklistGoal:{base.GetName()},{base.GetDescription()},{base.GetPoints()},{bonus},{target},{amountCompleted}";

        return representation;
    }

    public override string GetDetailsString()
    {
        return ($"{base.GetDetailsString()} -- Currently completed: {amountCompleted}/{target}");
    }

    public void SetAmount(int amount)
    {
        amountCompleted = amount;
    }


}
