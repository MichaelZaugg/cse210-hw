using System;

class Program
{

    static int RandomNumber() {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11); //Generate number between 1 and 10

        return number; //Return the random number as an int
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        /*
        //while loop
        int count = 0;
        while (count < 5) {
            System.Console.WriteLine($"count is = {count++}");
            //count = count + 1;
            //count += 1;
            //count++; - Use the value then increment 
            //++count; - Increment first then return the value
        }

        //do-while loop
        int moreCount = 0;
        do {
            System.Console.WriteLine($"moreCount = {moreCount++}");
        } while (moreCount < 5);

        //for loop
        //    Start  Stop  How is the value changing
        for(var i=0; i<5; ++i) {
            System.Console.WriteLine($"i = {i}");
        }
        */

        //Generate Random Number from RandomNumber()
        int number = RandomNumber();

        //Initializing
        int guess;
        int guess_count = 0;
        string done;

    do {
            //Ask for user guess
            System.Console.Write("Guess a number: ");
            guess = int.Parse(Console.ReadLine());

            if (guess < 1 || guess > 10){
                break;
            }
            
            //Check if guess is higher 
            if (guess > number) {
                System.Console.WriteLine("You're High");
                guess_count++;
            } else if(guess < number) {
            //Check if guess us lower
                System.Console.WriteLine("You're too low");
                guess_count++;
            } else {
                //Check if guess is match
                System.Console.WriteLine($"{guess} is correct");
                System.Console.WriteLine($"It took you {guess_count} guesses!");
                System.Console.Write("Start Again? [yes   no]: ");
                done = Console.ReadLine();
                if (done == "yes") {
                    //Initialize variables and go through the loop again
                    guess = 11;
                    guess_count = 0;
                    number = RandomNumber(); //Make new random number
                } else {
                    break;
                }
            }
    } while (number != guess);

    

    }
}