using System;

class Program
{
    static void Main(string[] args)
    {
        Run();
    }

    static private void Run() {

        while(true) {
            Console.Clear();
            int command = ShowMenu();

            if (command == 1) {
                //Breathing activity
                BreathingActivity breathing1 = new BreathingActivity();
                breathing1.Run();
            } else if (command == 2) {
                //Reflecting Activity
                ReflectingActivity reflect1 = new ReflectingActivity();
                reflect1.Run();
            } else if (command == 3) {
                //Listing Activing
                ListingActitivity list1 = new ListingActitivity();
                list1.Run();
            } else if (command == 4) {
                //Quit
                break;
            } else {
                //Invalid input
                System.Console.Write("Please try again - Press Enter to Continue -");
                Console.ReadLine();
            }

        }

    }

    static private int ShowMenu(){
        System.Console.WriteLine("Menu Options:\n 1. Start breathing activity\n 2. Start reflecting activity\n 3. Start listing activity\n 4. Quit");
        System.Console.Write("Select a choice from the menu: ");
        int command = int.Parse(Console.ReadLine());
        return command;
    }
    
}