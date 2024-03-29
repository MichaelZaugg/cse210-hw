using System;

public class Video 
{
   private string title;
   private string author;
   private float lenght;

   public List<Comment> comments = new List<Comment>();

    public Video(string title, string author, float lenght)
    {
        this.title = title;
        this.author = author;
        this.lenght = lenght;
    }

    public void GetComments()
    {
        foreach (Comment comment in comments)
        {
            comment.GetComment();
        }
    }
    public string GetVideoDetails()
    {
        return($"Title : {title} - Author: {author} - Lenght: {lenght} minutes - Number of commentaries: {comments.Count}.");
    }

}