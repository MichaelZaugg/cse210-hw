using System;

class Program
{
    static void Main(string[] args) {
        DisplayWelcomeMessage(); //Calls the welcome message

        //Call each function when intializing variables
        string users_name = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(users_name, squaredNumber); //Pass the variables into the display function
    }
    //Pretty straight forward what these functions do
    static void DisplayWelcomeMessage() {
        System.Console.WriteLine("Welcome to the program!"); 
    }
    static string PromptUserName() {
        System.Console.Write("Enter thine name: ");
        string user = Console.ReadLine();
        return user;
    }
    static int PromptUserNumber() {
        System.Console.Write("Which numerical value is your preference: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    static int SquareNumber(int number) {
        int square = number * number;
        return square;
    }
    static void DisplayResult(string name, int square) {
        System.Console.WriteLine($"{name}, if thine value was squared up it would be {square}");
    }
}