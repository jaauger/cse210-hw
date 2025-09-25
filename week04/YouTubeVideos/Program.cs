using System;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Auger", 60, "Java Programming Basics");
        videos.Add(video1);

        Video video2 = new Video("Auger", 60, "Python Programming basics");
        videos.Add(video2);

        Video video3 = new Video("Auger", 60, "C# Programming Basics");
        videos.Add(video3);

        video1.AddComment("Author 1", "Java Comment 1");
        video1.AddComment("Author 2", "Java Comment 2");
        video1.AddComment("Author 3", "Java Comment 3");

        video2.AddComment("Author 1", "Python Comment 1");
        video2.AddComment("Author 2", "Python Comment 2");
        video2.AddComment("Author 3", "Python Comment 3");

        video3.AddComment("Author 1", "C# Comment 1");
        video3.AddComment("Author 2", "C# Comment 2");
        video3.AddComment("Author 3", "C# Comment 3");

        for (int i = 0; i < videos.Count; i++)
        {
            videos[i].DisplayVideoInformation();
            videos[i].DisplayComments();
        }

    }   
}