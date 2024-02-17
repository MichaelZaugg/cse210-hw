
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;


public class Scripture {

    /*
     Keeps track of the reference and the text of the scripture. 
     Can hide words and get the rendered display of the text.
    */

    private List<Word> words;

    public Scripture(string scripture) {
        words = new List<Word>();  //Create new instance of the word list
        var parts = scripture.Split(" ");

        foreach(string part in parts) {
            Word word = new Word(part);  //Call the word class to create a word object 
            words.Add(word);
        }
        
    }

    public bool IsCompletelyHidden(){
        foreach(Word word in words) {
            //Go through each word and as the word class if it is hidden. If every word is hidden return a true to exit 
            if (word.Hidden() == false) {
                return false;
            }
        }

        return true;
    }

    public void HideWords() {
        //Gets the index of the target word to hide with the random number and checks if it is already hidden then hides it.
        var random = new Random();
        int wordIndex = random.Next(0, words.Count);
        bool isHidden = words[wordIndex].Hidden();

        if (isHidden == true){
            HideWords();
        }
        words[wordIndex] = words[wordIndex].Hide();
    }

    public void DisplayWords(){
        //Calls word class to display words
        foreach(Word word in words) {
            word.DisplayWord();
        }
    }
}