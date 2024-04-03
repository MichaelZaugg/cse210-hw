using System;

public class Swimming : Activity  
{
    private float laps;


    public Swimming(float laps, int year, int month, int day, float lenght): base(year, month, day, lenght)
    {
        this.laps = laps;
    }

    public override float GetSpeed()
    {
        return GetDistance() * 60 / GetLenght();
    }
    public override float GetDistance()
    {
        return laps * 50 / 1000;
    }


     public override string GetActivity()
    {
        return "Swimming";
    }
    public override float GetPace()
    {
        return GetLenght() / GetDistance();
    }

}