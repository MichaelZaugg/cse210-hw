//Michael Zaugg 1-12-2024
using System;

class Program
{
    static void Main(string[] args)
    {
        //Get user input
        System.Console.WriteLine("What is your first name?");
        string first_name = Console.ReadLine();

        System.Console.WriteLine("What is your last name?");
        string last_name = Console.ReadLine();

        //Write the user input to the console
        System.Console.WriteLine($"Your name is {last_name}, {first_name} {last_name}.");
    }
}