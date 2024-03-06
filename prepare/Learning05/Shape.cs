using System;

public abstract class Shape
{
    private string color;

    private double area;
    
    private string name;

    public string GetColor()
    {
        return color;
    }

    public Shape(string color)
    {
        SetColor(color);
    }

    public void SetColor(string color)
    {
        this.color = color;
    }

    public abstract double GetArea();
    
    
    public void SetName(string name)
    {
        this.name = name;

       
    }

    public string GetName()
    {
        return name;
    }



}
