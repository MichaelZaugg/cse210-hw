
using System;
using System.Runtime.CompilerServices; 

class Program
{

    static private string scriptureText = "And it came to pass that the Lord did visit them with his Spirit, and said unto them: Be comforted. And they were comforted. And the Lord said unto them also: Go forth among the Lamanites, thy brethren, and establish my word; yet ye shall be patient in long-suffering and afflictions, that ye may show forth good examples unto them in me, and I will make an instrument of thee in my hands unto the salvation of many souls.";
    static private string referenceText = "Alma 17:10-11";
    static void Main(string[] args)
    {
        Run();
    }

    static private void Run() {
        
        Scripture scripture = new Scripture(scriptureText);
        Reference reference = new Reference(referenceText);

        //In the run function - Display the scripture and reference with a prompt that says "Press enter or type 'quit' to exit"

        //Menu
        while (true) {
            Console.Clear();
            reference.Display(); //Display reference
            scripture.DisplayWords();//Display the scripture
            System.Console.Write("\n\nPress enter or type 'quit' to exit:\n->: ");
            string command = Console.ReadLine();

            if(command == "quit") {
                break;
            } else if (scripture.IsCompletelyHidden() == true) {
                //If the scripture is completely hidden then exit the program.
                break;
            } else {
                //Call scripture class to hide words
                scripture.HideWords();
            }
        }
    }
}