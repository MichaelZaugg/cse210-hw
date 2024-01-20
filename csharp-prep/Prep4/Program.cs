using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        //Initialize Variables
        int Sum = 0;
        int largestNumber = 0;
        int smallestPositive = 0;
        int input;

        //Lists - new keyword
        // Whattype name     Creat new list
        List<int> Numbers = new List<int>(); //Make Numbers list
        //var otherInts = new List<int>();
        System.Console.WriteLine("Enter a list of numbers, type 0 to exit");

        do {
            System.Console.Write("Enter a number: ");
            input = int.Parse(Console.ReadLine());

            if (input != 0) {
                Numbers.Add(input); //Add each input to the list if it is not 0

                //Find the largest number as it is entered into the program
                if (largestNumber == 0) {
                    largestNumber = input;
                } else if (largestNumber < input) {
                    largestNumber = input;
                }
            }

        } while (input != 0);

        //Iterate over items and add them together
        foreach(int number in Numbers){
            Sum += number;

            if (smallestPositive == 0) { //Set the smallestPositive to 0 so we can start comparing with the list
                smallestPositive = number;
            } else if (smallestPositive > number & number > 0){ //If smallestPositive is less than the current number and the number is greater than 0
                smallestPositive = number;
            }
        }

        float average = ((float)Sum) / Numbers.Count; //take the sum and divide it by how many numbers there are in the list

        Numbers.Sort(); //Sort the list from smallest to highest

        System.Console.WriteLine($"The Sum is: {Sum}");
        System.Console.WriteLine($"The average is: {average}");
        System.Console.WriteLine($"The largest number is: {largestNumber}");
        System.Console.WriteLine($"The smallest positive number is: {smallestPositive}");

        System.Console.WriteLine("The sorted list is:");
        foreach(int number in Numbers){
            System.Console.WriteLine(number);
        }
    }
}