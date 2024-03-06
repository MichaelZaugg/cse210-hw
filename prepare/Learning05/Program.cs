using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Clear();    
        Square sqrt = new Square("Red", 5);
        Console.WriteLine($"The square color is {sqrt.GetColor()} and the area is {sqrt.GetArea()}");

        Rectangle rec = new Rectangle("Blue", 4.5, 5.67);
        Console.WriteLine($"The rectangle color is {rec.GetColor()} and the area is {rec.GetArea()}");

        Circle cir = new Circle("Green", 8);
        Console.WriteLine($"The circle color is {cir.GetColor()} and the area is {cir.GetArea()}");


        List<Shape> form = new List<Shape>();
        form.Add(sqrt);
        form.Add(rec);
        form.Add(cir);

        foreach (Shape shap in form)
        {
            DisplayInformation(shap);
        }
    

    }
    public static void DisplayInformation(Shape shape)
    {
        Console.WriteLine($"The {shape.GetName()} color is {shape.GetColor()} and the area is {shape.GetArea()}.");
    }
}