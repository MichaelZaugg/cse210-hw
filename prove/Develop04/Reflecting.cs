using System;

public class ReflectingActivity : Activity 
{

    private List<string> prompts = new List<string>();
    private List<string> questions = new List<string>();
    public ReflectingActivity()
    {
        SetName("Reflecting");
        SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        prompts.Add("Think of a time when you stood up for someone else.");
        prompts.Add("Think of a time when you did something really difficult.");
        prompts.Add("Think of a time when you helped someone in need.");
        prompts.Add("Think of a time when you did something truly selfless.");
        questions.Add("Why was this experience meaningful to you?");
        questions.Add("Have you ever done anything like this before?");
        questions.Add("How did you get started?");
        questions.Add("How did you feel when it was complete?");
        questions.Add("What made this time different than other times when you were not as successful?");
        questions.Add("What is your favorite thing about this experience?");
        questions.Add("What could you learn from this experience that applies to other situations?");
        questions.Add("What did you learn about yourself through this experience?");
        questions.Add("How can you keep this experience in mind in the future?");
        
    }

    public void Run() {
        Console.Clear();
        DisplayStartingMessage();
        int runTime = int.Parse(Console.ReadLine());

        SetTime(runTime);

        
        Console.Clear();

        Console.WriteLine("Get Ready...");

        ShowSpinner(5);

        Console.WriteLine("Consider the following prompt:");
        DisplayPrompt();
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        
                
        if (Console.ReadKey().Key == ConsoleKey.Enter) {
            Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
            Console.Write("You may begin in: ");
            ShowCountDown(5);

            Console.Clear();

            DateTime time3 = DateTime.Now;
            DateTime time4 = time3.AddSeconds(runTime);

            while (DateTime.Now < time4) {
                            
                DisplayQuestions();
                ShowSpinner(4);

            }

        DisplayEndingMessage();
        ShowSpinner(5);

        } else { 

            DisplayEndingMessage();
            ShowSpinner(3);
        }



    }

    public string GetRandomPrompt() {
        Random prompt = new Random();
        int numb = prompt.Next(0, prompts.Count);
        
        string promp = prompts[numb];

        return promp;
    }

    public string GetRandomQuestion() {
        Random quest = new Random();
        int numb = quest.Next(0, questions.Count);
        
        string question = questions[numb];
        
        questions.RemoveAt(numb);

        if (questions.Count < 1) {
            Console.WriteLine("End of questions.");
        }

        return question;
    }

    public void DisplayPrompt() {
        string reflection = GetRandomPrompt();

        Console.WriteLine($"---{reflection}---");
    }

    public void DisplayQuestions() {
        string ask = GetRandomQuestion();

        Console.Write($"\n{ask}");
    }
    

}