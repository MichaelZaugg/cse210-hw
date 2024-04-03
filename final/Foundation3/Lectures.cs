using System;

public class Lectures : Event  
{
    private string speaker;
    private int capacity;

    public Lectures(string speaker, int capacity, string title, string description, string date, string time) : base(title, description, date, time)
    {
        this.speaker = speaker;
        this.capacity = capacity;
    }
    public void GetFullInformation()
    {
        Console.WriteLine($"\nType of Event: Lectures");
        Console.WriteLine(GetInformation());
        Console.WriteLine(GetStandardDetails());
    }

    public string GetInformation()
    {
        return($"Speaker: {speaker} - Capacity: {capacity} people");
    }

}