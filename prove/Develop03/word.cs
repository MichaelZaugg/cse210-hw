
using System.Runtime.InteropServices;
using System.Text;


public class Word {

    /*
    Word - Keeps track of a single word and whether 
    it is shown or hidden.
    */

    private string word;
    private bool isHidden;

    public Word(string word, bool hidden=false){
        //Constructor for the Word class, takes a string for the word and a booleen
        this.word = word;
        this.isHidden = hidden;
    }

    public void DisplayWord() {
        System.Console.Write($"{word} "); //Displays the single word with a space afterwads
    }

    public Word Hide() {
        //Creates a new string with the current word and replaces each character with an underline
        string Hide = new string('_', word.Length);

        Word Hidden = new Word(Hide, true); //Creates a new word with the modified string

        return Hidden;
        
    }

    public bool Hidden() {
        //Checks if the current word is hidden or not
        if(isHidden == true) {
            return true;
        } else {
            return false;
        }
        
    }

}