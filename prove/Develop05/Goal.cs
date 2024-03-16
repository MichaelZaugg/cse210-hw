using System;

public abstract class Goal 
{
    private string Name;
    private string description;
    private string points;

    public Goal(string name, string description, string points)
    {
        this.Name = name;
        this.description = description;
        this.points = points;

    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
       
        
        if (IsComplete())
        {
            return($"[x] {Name} ({description}).");
        
        } else 
        {
            return($"[ ] {Name} ({description}).");
        }
    }

    public abstract string GetStringRepresentation();

    public string GetName()
    {
        return Name;
    }

    public string GetDescription()
    {
        return description;
    }

    public int GetPoints()
    {
        int point = int.Parse(points);

        return point;
    }

   public void SetPoints(int points)
   {

    this.points = points.ToString();

   } 
   

}