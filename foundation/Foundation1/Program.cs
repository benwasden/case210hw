using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Black Cat Running", "Ben Wasden", 600);

        Comment video1Comment1 = new Comment("Jessica Zhang", "He's so flexible :)");
        Comment video1Comment2 = new Comment("Steve Wasden", "He'd bite my nose off");
        Comment video1Comment3 = new Comment("Chris Wasden", "He looks just like my cat!");

        video1.AddComment(video1Comment1);
        video1.AddComment(video1Comment2);
        video1.AddComment(video1Comment3);

        videos.Add(video1);


        Video video2 = new Video("Alarmo Reveal", "Nintendo", 800);

        Comment video2Comment1 = new Comment("Joe Blow", "This would be terrifying to wake up to");
        Comment video2Comment2 = new Comment("Hasrat", "Crazy that this is the next console");
        Comment video2Comment3 = new Comment("Minty", "I'm totally picking the Pikmin one");

        video2.AddComment(video2Comment1);
        video2.AddComment(video2Comment2);
        video2.AddComment(video2Comment3);

        videos.Add(video2);

        
        Video video3 = new Video("iOS 18 Features", "Shaun", 1200);
        
        Comment video3Comment1 = new Comment("Mark Watney", "This would've been handy to get home from Mars...");
        Comment video3Comment2 = new Comment("AppleFan", "Nice that we can finally move the apps wherever");
        Comment video3Comment3 = new Comment("AndroidBoy", "Crazy that it's taken em 10 years to add this stuff");

        video3.AddComment(video3Comment1);
        video3.AddComment(video3Comment2);
        video3.AddComment(video3Comment3);

        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.Display();
        }
    }
}