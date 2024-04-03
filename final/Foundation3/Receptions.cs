using System;

public class Receptions : Event 
{
    private string email;

    public Receptions(string email, string title, string description, string date, string time) : base(title, description, date, time)
    {
        this.email = email;
    }
     public void GetFullInformation()
    {
        Console.WriteLine($"\nType of Event: Receptions");
        Console.WriteLine($"RVSP email: {GetEmail()}");
        Console.WriteLine(GetStandardDetails());
    }

    public string GetEmail()
    {
        return email;
    }

}