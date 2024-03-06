using System;

public class Square : Shape 
{

    private double side;

    
    public Square(string color, double side) : base(color)
    {
        this.side = side;
        SetName("square");
    }

    public override double GetArea()
    {
        return Math.Round(side * side, 2);
    }
    
}
