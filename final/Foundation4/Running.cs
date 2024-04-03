using System;

public class Running : Activity
{
    private float distance;


    public Running(float distance, int year, int month, int day, float lenght): base(year, month, day, lenght)
    {
        this.distance = distance;
    }

    public override float GetSpeed()
    {
        return distance *60 / GetLenght();
    }
    public override float GetDistance()
    {
        return distance;
    }

    public override string GetActivity()
    {
        return "Running";
    }
    public override float GetPace()
    {
        return GetLenght() / distance;
    }


}