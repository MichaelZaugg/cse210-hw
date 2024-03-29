using System;

class Program
{
    static void Main(string[] args)
    {
       List<Video> videoList = new List<Video>();
        
       Video v1 = new Video("Rick Roll", "Ricky_101", 10);
       Comment comment1v1 = new Comment("Nunchuck-Steve", "Quality is top-notch");
       Comment comment2v1 = new Comment("Steven Seagal", "I am the master, I rick roll the rick roll");
       Comment comment3v1 = new Comment("Mark Zuckerberg", "This will be a fine addition to Meta");

        v1.comments.Add(comment1v1);
        v1.comments.Add(comment2v1);
        v1.comments.Add(comment3v1);

        Video v2 = new Video("Flat Earth is Real", "Samuel Shenton", 15);
        Comment comment1v2 = new Comment("NASA", "Everything is flat");
        Comment comment2v2 = new Comment("Elon Musk", "Flat Earth theory best theory");
        Comment comment3v2 = new Comment("Albert Einstein", "Why is the moon upside down in South America?");

        v2.comments.Add(comment1v2);
        v2.comments.Add(comment2v2);
        v2.comments.Add(comment3v2);

        Video v3 = new Video("Fried Rice Made Simple", "Uncle Roger", 45);
        Comment comment1v3 = new Comment("Gordon Ramsay", "For what we are about to eat, may the Lord make us truly not vomit.");
        Comment comment2v3 = new Comment("Donald Trump", "I do know this: other countries are eating our lunch.");
        Comment comment3v3 = new Comment("Jamie Oliver", "Woooowzaa!");

        v3.comments.Add(comment1v3);
        v3.comments.Add(comment2v3);
        v3.comments.Add(comment3v3);

        videoList.Add(v1);
        videoList.Add(v2);
        videoList.Add(v3);

        foreach (Video video in videoList)
        {
            Console.WriteLine($"\n{video.GetVideoDetails()}");
            video.GetComments();
        }
    }
}