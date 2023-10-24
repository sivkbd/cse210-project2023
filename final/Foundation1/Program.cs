using System;

class Program
{
    static void Main(string[] args)
    {
    
        var videos = new List<Video>
        {
            new Video { Title = "Video 1", Author = "Author 1", Length = 200 },
            new Video { Title = "Video 2", Author = "Author 2", Length = 300 },
            new Video { Title = "Video 3", Author = "Author 3", Length = 400 },
        };

        foreach (var video in videos)
        {
            for (int i = 0; i < 4; i++)
            {
                video.AddComment($"User{i}", $"This is comment {i} on {video.Title}");
            }
        }

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}, Author: {video.Author}, Length: {video.Length}s");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");
            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"Comment by {comment.Name}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}

    