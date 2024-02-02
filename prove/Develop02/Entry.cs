namespace Journal;

public class Entry {

    public string Date;
    public string Response;
    public string Prompt;

    public Entry(string Response, string Prompt, string Date) {
        this.Response = Response; //this.Response reffering to the original instance of Response
        this.Prompt = Prompt;
        this.Date = Date;
    }
    static public string RandomPrompt(){
        //Make a list of prompts and pick a random number from the amount of prompts in the list then use that number to return the prompt
        var random = new Random();
        var prompts = new List<string> {
            "Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?"
        };
        int index = random.Next(prompts.Count);
        return prompts[index];
    }
    public string Export(){

        var data = ($"{Date}^{Prompt}^{Response}"); //Export the entry in Date^Prompt^Response format
        return data;
    }
    public void Display() {
        System.Console.WriteLine($"\nDate: {Date} - Prompt: {Prompt}\n{Response}");
    }
}