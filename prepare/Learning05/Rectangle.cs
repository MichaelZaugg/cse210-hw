using System;

public class Rectangle : Shape 
{
    private double length;

    private double width;

    public Rectangle(string color, double length, double width) : base(color)
    {
        this.length = length;
        this.width = width;
        SetName("rectangle");
    }

    public override double GetArea()
    {
        return  Math.Round(length * width, 2);
    }
}