using System;

public class ListingActitivity : Activity {
    private List<string> prompts = new List<string>();
    private int count;

    private List<string> responses = new List<string>();

    public ListingActitivity(){
        SetName("Listing");
        SetDescription("This activity will help you reflect on the good things in your life by having list as many thing as you can in a certain area.");
        prompts.Add("Who are people that you appreciate?");
        prompts.Add("What are personal strengths of yours?");
        prompts.Add("Who are people that you have helped this week?");
        prompts.Add("When have you felt the Holy Ghost this month?");
        prompts.Add("Who are some of your personal heroes?");

    }

    public void Run(){
        Console.Clear();
        DisplayStartingMessage();
        int runTime = int.Parse(Console.ReadLine());

        SetTime(runTime);

        Console.Clear();

        Console.WriteLine("Get Ready...");
        ShowSpinner(8);

        Console.WriteLine("\nList as many responses you can to the following prompt:");
        GetRandomPrompt();
        Console.Write("You may begin in...");
        ShowCountDown(5);
        Console.WriteLine("");
        List<string> list = new List<string>();

        int clock = GetDuration();

        DateTime time = DateTime.Now;
        DateTime timeEnd = time.AddSeconds(clock);

        while (DateTime.Now < timeEnd) {
            if (DateTime.Now < timeEnd) {
                System.Console.Write(">");
                list = GetListFromUser();
            }             
           
        }

        Console.WriteLine($"You listed {list.Count} items!");
        DisplayEndingMessage();
        ShowSpinner(5);

    }

    public void GetRandomPrompt() {
        Random prompt = new Random();
        int numb = prompt.Next(0, prompts.Count);
        
        Console.WriteLine($"---{prompts[numb]}---");


    }

    public List<string> GetListFromUser() {
        
            string answer = Console.ReadLine();
            responses.Add(answer);
        
        

        return responses;
        
    }
}