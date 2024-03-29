using System;

public class Customer
{
    private string name;
    private Address  address = new Address();

public Customer()
{

}

public string GetName()
{
    return name;
}
public string GetAddress()
{
    return address.GetAddress();
}
public void SetAddress(string address, string city, string state, string country)
{
    this.address.SetAddress(address, city, state, country);
}
public bool IsUSA()
{
    return address.GetUSA();
}

public void SetName(string name)
{
    this.name = name;

}


}