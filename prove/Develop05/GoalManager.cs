using System;
using System.IO;

public class GoalManager
{
    private List<Goal> goals;

    private int score;

public GoalManager()
{
    this.goals = new List<Goal>();
    this.score = 0;
}

public int Start()
{
    System.Console.WriteLine($"You have {score} points. \n");
    System.Console.WriteLine("Menu Options:\n1. Create New Goal\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record Event\n6. Quit");
    System.Console.Write("Select a choice from the menu: ");
    int command = int.Parse(Console.ReadLine());
    return command;

}

public void CreateGoaL()
{
    Console.Clear();
    Console.WriteLine("The types of Goals are:\n1. Simple Goal\n2. Eternal Goal\n3. ChecklistGoal\nWhich type of goal would you like to create? ");

    string goal = Console.ReadLine();
    Console.Write("What is the name of your goal: "); 
    string name = Console.ReadLine();
    Console.Write("What is the short description of it? ");
    string description = Console.ReadLine();
    Console.Write("What is the amount of points for this goal: ");
    string points = Console.ReadLine();

    if (goal == "1") {
        SimpleGoal simple = new SimpleGoal(name, description, points);

        goals.Add(simple);    

    } else if (goal == "2") {
         EternalGoal simple = new EternalGoal(name, description, points);

        goals.Add(simple);    

    }  else if (goal == "3") {
        Console.Write("How many times does this goal need to be accomplished for a bonus?");
        int target = int.Parse(Console.ReadLine());

        Console.Write("What is the bonus for accomplishing it that many times?");
        int bonus = int.Parse(Console.ReadLine());

        ChecklistGoal simple = new ChecklistGoal(name, description, points, target, bonus);
        goals.Add(simple);

    } else {
        Console.WriteLine("Invalid option. Start over.");
    }

    

}

public void ListGoalsNames()
{
    int count = 1;
     Console.WriteLine("\nThe goals are: ");
    foreach (Goal name in goals)
    {
        Console.WriteLine($"{count}. {name.GetName()}");
        count++;
    }
}

public void ListGoalsDetails() 
{
    int count = 1;

    Console.WriteLine("The goals are: ");

    foreach (Goal goal in goals) 
    {
        Console.WriteLine($"{count}. {goal.GetDetailsString()}");
        count++;
    }
    Console.ReadLine();
}

public void SaveGoals()
{
    Console.Write("What is the filename?");
    string fileName= Console.ReadLine();

    using (StreamWriter outputFile = new StreamWriter(fileName)) 
    {
        outputFile.WriteLine(score);
        foreach (Goal goal in goals)
        {
            outputFile.WriteLine(goal.GetStringRepresentation());
        }
    }
}

public void LoadGoals()
{
    Console.Write("What is the filename? ");
    string file = Console.ReadLine();
    string[] lines = System.IO.File.ReadAllLines(file);

     score = int.Parse(lines.First());

    string[] text = lines.Skip(1).ToArray();
    

    foreach(string line in text)
    {
        

               
        string[] parts = line.Split(":");

        string goalType = parts[0];

        string details = parts[1];

        string[] part = details.Split(",");

        if (goalType == "SimpleGoal")
        {
            SimpleGoal simplePart = new SimpleGoal(part[0], part[1], part[2], bool.Parse(part[3]));

            goals.Add(simplePart);
            
        } else if (goalType == "EternalGoal")
        {
            EternalGoal eternalPart = new EternalGoal(part[0], part[1], part[2]);
                
            goals.Add(eternalPart);

        } else if (goalType == "ChecklistGoal")
        {
            ChecklistGoal checklistPart = new ChecklistGoal(part[0], part[1], part[2], int.Parse(part[4]), int.Parse(part[3]));
            checklistPart.SetAmount(int.Parse(part[5]));

            goals.Add(checklistPart);
        }

        } 
    }


public void RecordEvent()
{
    ListGoalsNames();
    Console.Write("Which Goal did you accomplish?");
    int goalCompleted = int.Parse(Console.ReadLine());

    goals[goalCompleted - 1].RecordEvent();

    int earnedPoints = goals[goalCompleted - 1].GetPoints();

    score += earnedPoints; 

    Console.WriteLine($"\nCongratulations! You have earned {earnedPoints} points!");

    Console.WriteLine($"\nYou now have {score} points.");
    Console.ReadLine();
}

}