using System;

class Program
{
    static void Main(string[] args)
    {
        Run();
    }

    static private void Run()
    {
        GoalManager goalManager = new GoalManager();
        while(true)
        {
            Console.Clear();
            int input = goalManager.Start();

            if (input == 1) {
                    //Create New Goal
                    goalManager.CreateGoaL();
                } else if (input == 2) {
                    //List Goals
                    goalManager.ListGoalsDetails();
                } else if (input == 3) {
                    //Save Goals
                    goalManager.SaveGoals();
                } else if (input == 4) {
                    //Load Goals
                    goalManager.LoadGoals();
                } else if (input == 5) {
                    //Record Event
                    goalManager.RecordEvent();
                } else if (input == 6) {
                    //Quit
                    break;
                } else {
                    //Invalid input
                    System.Console.Write("Please try again - Press Enter to Continue -");
                    Console.ReadLine();
                }
        }


    }
}