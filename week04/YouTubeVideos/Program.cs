using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        List<Video> videos = new List<Video>();

        //1st Video
        Video video1 = new Video("Example video 1", "Author 1", 123);
        video1.addComment(new Comment("User1 video 1", "Lorem ipsum dolor sit amet."));
        video1.addComment(new Comment("User2 Video 1", "Place holder for a comment."));
        video1.addComment(new Comment("User3 Video 1", "Another comment here. (idk what else to put haha)"));

        //2nd Video
        Video video2 = new Video("Example video 2", "Author 2", 456);
        video2.addComment(new Comment("User1 video 2", "Lorem ipsum dolor sit amet."));
        video2.addComment(new Comment("User2 Video 2", "2nd Place holder for anoter comment."));
        video2.addComment(new Comment("User3 Video 2", "Another comment here. (help! I´m running out of ideas Lol)"));

        //3rd Video
        Video video3 = new Video("Example video 3", "Author 3", 789);
        video3.addComment(new Comment("User1 video 3", "Lorem ipsum dolor sit amet."));
        video3.addComment(new Comment("User2 Video 3", "3rd Place holder for ANOTER comment."));
        video3.addComment(new Comment("User3 Video 3", "Another comment here. (ok I give upXD)"));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        Console.WriteLine($"{videos.Count} where successfully added\n");

        foreach (Video video in videos)
        {
            Console.WriteLine(video.GetDisplayText());
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}\n");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"Name: {comment.GetName()}: {comment.GetText()}");
            }
        }
    }
}