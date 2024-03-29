using System;

public class Comment 
{
   private string name;
   private string text;

    public Comment(string name, string text)
    {
        this.name = name;
        this.text = text;
    }

    public void GetComment()
    {
        Console.WriteLine($"{name} says: {text}");
    }

}