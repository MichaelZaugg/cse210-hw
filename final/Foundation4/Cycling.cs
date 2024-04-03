using System;

public class Cycling : Activity 
{

    private float speed; 


    public Cycling(float speed, int year, int month, int day, float lenght): base(year, month, day, lenght)
    {
        this.speed = speed;

    }

    public override string GetActivity()
    {
        return "Cycling";
    }   
    public override float GetDistance()
    {
        return speed * GetLenght()/60;
    }

    public override float GetSpeed()
    {
        return speed;
    }
    public override float GetPace()
    {
        return GetLenght()/ GetDistance();
    }


}
