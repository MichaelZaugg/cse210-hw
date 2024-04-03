using System;

public class Outdoor : Event
{
    private string statement;


    public Outdoor(string statement, string title, string description, string date, string time) : base(title, description, date, time)
    {
        this.statement = statement;
    }

     public void GetFullInformation()
    {
        Console.WriteLine($"\nType of Event: Outdoor");
        Console.WriteLine($"Forecast: {GetStatement()}");
        Console.WriteLine(GetStandardDetails());
    }

    public string GetStatement()
    {
        return statement;
    }
}