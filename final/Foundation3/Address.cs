using System;

public class Address  
{
    private string streetAddress;
    private string city;
    private string state;
    private string country;

    public Address()
    {

    }
    public void SetAddress(string address, string city, string state, string country)
    {
        this.streetAddress = address;
        this.city = city;
        this.state = state;
        this.country = country;
    }

    public string GetAddress()
    {
        return($"Address: {streetAddress}, {city}, {state}, {country}");

    }


}