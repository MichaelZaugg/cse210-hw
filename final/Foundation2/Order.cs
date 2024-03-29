using System;

public class Order
{
    private Customer customer = new Customer();

    private List<Product> products = new List<Product>();


public string GetPackingLabel()
{
    string packLabel="";
    int order = 1;

    foreach (Product product in products)
    {
        packLabel += $"{order}.{product.GetPack()}\n";
        order++; 

    }

    return packLabel;
}

public double GetShippingCost()
{
    if (customer.IsUSA())
    {
        return 5;
    } else
    {
        return 35;
    }
}
public string GetShippingLabel()
{
    return($"Name: {customer.GetName()}\n{customer.GetAddress()}");
}

public void SetName(string name)
{
    customer.SetName(name);
}

public void AddList(Product product)
{
    products.Add(product);
}
public void SetAddress(string address, string city, string state, string country)
{
    customer.SetAddress(address, city, state, country);
}
public double GetTotal()
{
    double sum = 0;

    foreach (Product product in products)
    {
        sum += product.GetProductTotal();
    }

    sum += GetShippingCost();

    return sum;
}




}