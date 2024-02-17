
public class Reference { 

    /*
    Reference - Keeps track of the book, chapter, 
    and verse information.
    */

    private string Book;
    private string Chapter;
    private string Verse;


    public Reference(string reference) {
        //Constructor for the Book, Chapter, and Verses
        var Book = reference.Split(" ");
        var Chapter = Book[1].Split(":");
        var Verse = Chapter[1];

        this.Book = Book[0];
        this.Chapter = Chapter[0];
        this.Verse = Verse;
    }

    public void Display() {
        System.Console.Write($"{Book} {Chapter}:{Verse} ");
    }
}