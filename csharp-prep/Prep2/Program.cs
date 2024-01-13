using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");


        Console.WriteLine("What's your age?");

        var ageString = Console.ReadLine();

        Console.WriteLine($"My age is {ageString}");
        //or Console.WriteLine("My age is " + age + ".");


        //Convert string to int
        int age = int.Parse(ageString);

        if (age < 18) {

            Console.WriteLine("Ahhhhhhhh");

        }
    }

}