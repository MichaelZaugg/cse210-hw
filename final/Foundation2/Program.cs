using System;

class Program
{
    static void Main(string[] args)
    {
        Order order1 = new Order();
        order1.SetName("Sir Chewbacca");
        order1.SetAddress("10th Street", "Honolulu", "Hawaii", "USA");

        Product product1 = new Product("Bantha", "001", 400.50, 3);
        Product product2 = new Product("Sand", "002", 7.53, 5);
        Product product3 = new Product("Beans", "003", 20.95, 40);

        order1.AddList(product1);
        order1.AddList(product2);
        order1.AddList(product3);

        Order order2 = new Order();
        order2.SetName("Jango Fett");
        order2.SetAddress("Tipoca City", "Kamino", "Rishi Maze", "Galactic North");

        Product product4 = new Product("Mandalorian Helmet", "009", 560000.00, 1);
        Product product5 = new Product("Brownies", "015", 0.50, 50);
        Product product6 = new Product("Boba's Braces", "007", 300.02, 1);

        order2.AddList(product4);
        order2.AddList(product5);
        order2.AddList(product6);

        Console.WriteLine("Order 1:");

        Console.WriteLine($"Packing Label\n{order1.GetPackingLabel()}");
        Console.WriteLine($"Shipping Label:\n{order1.GetShippingLabel()}");
        Console.WriteLine($"\nTotal: ${order1.GetTotal()}");

        Console.WriteLine("\nOrder 2:");

        Console.WriteLine($"Packing Label\n{order2.GetPackingLabel()}");
        Console.WriteLine($"Shipping Label:\n{order2.GetShippingLabel()}");
        Console.WriteLine($"\nTotal: ${order2.GetTotal()}");


    }
}