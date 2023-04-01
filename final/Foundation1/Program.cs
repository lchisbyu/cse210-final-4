using System;
using System.Collections.Generic;

namespace YouTubeMonitoring
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Video> videos = new List<Video>();

            // Create 3-4 videos and add comments
            Video video1 = new Video("Video 1", "Author 1", 120);
            video1.AddComment(new Comment("Commenter 1", "Great video!"));
            video1.AddComment(new Comment("Commenter 2", "Thanks for sharing!"));
            video1.AddComment(new Comment("Commenter 3", "I learned a lot from this video."));
            videos.Add(video1);

            Video video2 = new Video("Video 2", "Author 2", 180);
            video2.AddComment(new Comment("Commenter 1", "Very informative."));
            video2.AddComment(new Comment("Commenter 2", "I love this channel!"));
            videos.Add(video2);

            Video video3 = new Video("Video 3", "Author 3", 240);
            video3.AddComment(new Comment("Commenter 1", "I have a question."));
            video3.AddComment(new Comment("Commenter 2", "Can you make a video on this topic?"));
            video3.AddComment(new Comment("Commenter 3", "Excellent!"));
            video3.AddComment(new Comment("Commenter 4", "Keep up the great work."));
            videos.Add(video3);

            // Iterate through the list of videos and display information
            foreach (var video in videos)
            {
                Console.WriteLine("Title: " + video.Title);
                Console.WriteLine("Author: " + video.Author);
                Console.WriteLine("Length (in seconds): " + video.Length);
                Console.WriteLine("Number of comments: " + video.GetNumberOfComments());

                foreach (var comment in video.GetComments())
                {
                    Console.WriteLine("Comment by " + comment.Name + ": " + comment.Text);
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
