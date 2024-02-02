namespace Journal;
using System;
using Microsoft.VisualBasic;

class Program
{
    static public Journal journal;  //Create journal instants

    //Get system date 
    static DateTime theCurrentTime = DateTime.Now;
    static string dateText = theCurrentTime.ToShortDateString();

    static void Main(string[] args)
    {
        //Make new instance of Journal or Make a new journal
        journal = new Journal();
        Run();
    }

    static public void Run() {
        bool keepGoing = true; //If it is false then the program will close

        while(keepGoing) {
            Console.Clear();
            var selection = ShowMenu();


            if (selection == 1) {
                //Add entry
                Console.Clear();
                string RandomPrompt = Entry.RandomPrompt();

                System.Console.Write($"{RandomPrompt} ");
                string Response = Console.ReadLine();
                //Make a new entry by calling the Entry class and providing the response, prompt, and date
                var entry = new Entry(Response, RandomPrompt, dateText);
                journal.AddEntry(entry); //Call the journal class to add the new entry 
            } else if (selection == 2) {
                //display entrys
                journal.Display(); //Call journal to show all entries
                string pause = Console.ReadLine();
            } else if (selection == 3) {
                //Load Entrys
                LoadFromFile();
            } else if (selection == 4) {
                //Save Entrys
                SaveToFile();
            } else if (selection == 5) {
                //Quit
                keepGoing = false;
            } else {
                System.Console.WriteLine("Unknown Command - Try again"); //If the command is not found then retry
                string pause = Console.ReadLine(); //Pause so the user can read
            }
        }
    }

    static int ShowMenu(){
        //Display the menu for the user
        System.Console.WriteLine("Welcome to the Jounral Program!\nPlease select one of the following choices:");
        System.Console.Write("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\nSelect->: ");
        string input = Console.ReadLine();
        return int.Parse(input);
    }

    static public void SaveToFile() {
        Console.Clear();
        System.Console.Write("What is the filename? ");

        string Filename = Console.ReadLine();
        journal.Export(Filename); //Call the journal class to export its entries
    }

    static public void LoadFromFile() {
        Console.Clear();
        System.Console.Write("What is the filename? ");
        string Filename = Console.ReadLine();

        FileManager.ReadFromFile(Filename, journal); //Call the filemanager class to find and load the data from the txt file.
    }
}