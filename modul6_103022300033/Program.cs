using System;
using System.Collections;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        Random random = new Random();
        this.id = random.Next(10000, 99999);
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        playCount += count;
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine("Video ID: " + id);
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Play Count: " + playCount);
    }

    public int GetPlayCount()
    {
        return playCount;
    }

    public string GetTitle()
    {
        return title;
    }
}

public class SayaTubeUser
{
    private int id;
    private List<SayaTubeVideo> uploadedVideos;
    public string username;

    public SayaTubeUser(string username)
    {
        Random randomUser = new Random();
        this.id = randomUser.Next(10000, 99999);
        this.uploadedVideos = new List<SayaTubeVideo>();
        this.username = username;
    }

    public int GetTotalVideoPlayCount()
    {
        int totalPlayCount = 0;
        foreach (SayaTubeVideo video in uploadedVideos)
        {
            totalPlayCount += video.GetPlayCount();
        }
        return totalPlayCount;
    }

    public void AddVideo(SayaTubeVideo video)
    {
        uploadedVideos.Add(video);
    }

    public void PrintAllVideoPlaycount()
    {
        Console.WriteLine($"User: {username}");
        for (int i = 0; i < uploadedVideos.Count; i++)
        {
            Console.WriteLine($"Video {i + 1} judul: {uploadedVideos[i].GetTitle()}");
        }
    }
}

class Program
{
    static void Main()
    {
        SayaTubeUser user = new SayaTubeUser("Ilham_Ridzuan");
        
        SayaTubeVideo video1 = new SayaTubeVideo($"Review FIlm Inception {user.username}");
        user.AddVideo(video1);
        video1.IncreasePlayCount(10);
        video1.PrintVideoDetails();
        Console.WriteLine(" ");

        SayaTubeVideo video2 = new SayaTubeVideo($"Review FIlm The Dark Knight {user.username}");
        user.AddVideo(video2);
        video2.IncreasePlayCount(10);
        video2.PrintVideoDetails();
        Console.WriteLine(" ");

        SayaTubeVideo video3 = new SayaTubeVideo($"Review FIlm Interstellar {user.username}");
        user.AddVideo(video3);
        video3.IncreasePlayCount(10);
        video3.PrintVideoDetails();
        Console.WriteLine(" ");

        SayaTubeVideo video4 = new SayaTubeVideo($"Review FIlm Parasite {user.username}");
        user.AddVideo(video4);
        video4.IncreasePlayCount(10);
        video4.PrintVideoDetails();
        Console.WriteLine(" ");

        SayaTubeVideo video5 = new SayaTubeVideo($"Review FIlm The Shawshank Redemption {user.username}");
        user.AddVideo(video5);
        video5.IncreasePlayCount(10);
        video5.PrintVideoDetails();
        Console.WriteLine(" ");

        SayaTubeVideo video6 = new SayaTubeVideo($"Review FIlm Forrest Gump {user.username}");
        user.AddVideo(video6);
        video6.IncreasePlayCount(10);
        video6.PrintVideoDetails();
        Console.WriteLine(" ");

        SayaTubeVideo video7 = new SayaTubeVideo($"Review FIlm The GodFather {user.username}");
        user.AddVideo(video7);
        video7.IncreasePlayCount(10);
        video7.PrintVideoDetails();
        Console.WriteLine(" ");

        SayaTubeVideo video8 = new SayaTubeVideo($"Review FIlm The Matrix {user.username}");
        user.AddVideo(video8);
        video8.IncreasePlayCount(10);
        video8.PrintVideoDetails();
        Console.WriteLine(" ");

        SayaTubeVideo video9 = new SayaTubeVideo($"Review FIlm Green Miles {user.username}");
        user.AddVideo(video9);
        video9.IncreasePlayCount(10);
        video9.PrintVideoDetails();
        Console.WriteLine(" ");

        SayaTubeVideo video10 = new SayaTubeVideo($"Review FIlm Cek Toko Sebelah {user.username}");
        user.AddVideo(video10);
        video10.IncreasePlayCount(10);
        video10.PrintVideoDetails();
        Console.WriteLine(" ");

        Console.WriteLine($"Total Play Count: {user.GetTotalVideoPlayCount()}");

        user.PrintAllVideoPlaycount();
    }
}