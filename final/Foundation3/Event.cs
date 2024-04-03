using System;

public class Event  
{
    private string title;
    private string description;
    private string date;
    private string time;
    private Address address = new Address();

    public Event(string title, string description, string date, string time)
    {
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
       

    }

    public void SetAddress(string address, string city, string state, string country)
    {
        this.address.SetAddress(address, city, state, country);
    }
    public string GetShortDescription()
    {
        return($"Event: {title} - Date: {date}");
    }
    public string GetStandardDetails()
    {
        return($"Event: {title}\nDescription: {description} - Date/time : {date} - {time}\n{address.GetAddress()}");

    }


}