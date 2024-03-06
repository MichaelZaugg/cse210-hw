using System;

public class Circle : Shape 
{
    private double radius;

    public Circle(string color, double radius) : base(color)
    {
        this.radius = radius;
        SetName("circle");
    }

    public override double GetArea()
    {
        return Math.Round(Math.PI * radius * radius, 2);
    }
}