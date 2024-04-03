using System;

class Program 
{
    static void Main(string[] args) {
        Console.Clear();

        List<Activity> list = new List<Activity>();
        
        Running run = new Running(13, 2024, 5, 10, 120);
        Cycling cyc = new Cycling(30, 2024, 10, 1, 60);
        Swimming swim = new Swimming(10, 2024, 3, 22, 3);

        list.Add(run);
        list.Add(cyc);
        list.Add(swim);

        foreach (Activity activity in list)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}