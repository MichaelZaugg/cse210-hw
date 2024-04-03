using System;
 
public abstract class Activity 
{

    private DateTime date;
    private float lenght;

    public abstract float GetDistance();

    public abstract float GetSpeed();

    public abstract float GetPace();
    public abstract string GetActivity();

    public Activity(int year, int month, int day, float lenght)
    {
        this.date = new DateTime(year, month, day);

        this.lenght = lenght;
    }

    public string GetDate()
    {   
        DateTime dateOnly = date.Date;
        return dateOnly.ToString("dd-MM-yyyy");
    }

    public float GetLenght()
    {
        return lenght;
    }


    public string GetSummary()
    {
    
        return($"Date: {GetDate()} - {GetActivity()} ({Math.Round(GetLenght(),2)} min) - Distance: {Math.Round(GetDistance(), 2)} kilometers, Speed: {Math.Round(GetSpeed(),2)}km/hour, Pace: {Math.Round(GetPace(),2)} min/km.");
    
    }

}