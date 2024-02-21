using System;

class Program {
    static void Main(string[] args) {
    
        Assignment a1 = new Assignment("Bob Schmidt", "Underwater Basket Weaving"); //Base asignment object with the two atributes
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("MacBurg Donald", "Derivatives", "8.9", "7-25"); //Derived class of Assignment with new attributes for section and problems
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Bonsai Noodles", "Mars History", "The fall of Bean the great"); //Another sub class this time with topic and title of paper
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}