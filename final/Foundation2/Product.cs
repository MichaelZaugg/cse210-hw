using System;

public class Product
{
    private string name;
    private string productId;
    private double price;
    private double quantity;

public void SetProduct(string name, string id, double price, double quantity)
{
    this.name = name;
    this.productId = id;
    this.price = price;
    this.quantity = quantity;
}
public Product(string name, string id, double price, double quantity)
{
    this.name = name;
    this.productId = id;
    this.price = price;
    this.quantity = quantity;
}
public string GetPack()
{
    return($"ID/Name: {productId}/{name}");
}
public double GetProductTotal()
{
    return price * quantity;
}



}



