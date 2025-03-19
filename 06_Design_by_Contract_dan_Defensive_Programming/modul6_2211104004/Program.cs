using System;
using System.Collections.Generic;

class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        Random random = new Random();
        this.id = random.Next(10000, 99999); // 5-digit random ID
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        if (count > 0)
        {
            this.playCount += count;
        }
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine($"Video ID: {id}");
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Play Count: {playCount}");
        Console.WriteLine();
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

class SayaTubeUser
{
    private string username;
    private List<SayaTubeVideo> uploadedVideos;

    public SayaTubeUser(string username)
    {
        this.username = username;
        this.uploadedVideos = new List<SayaTubeVideo>();
    }

    public void AddVideo(SayaTubeVideo video)
    {
        uploadedVideos.Add(video);
    }

    public int GetTotalVideoPlayCount()
    {
        int total = 0;
        foreach (var video in uploadedVideos)
        {
            total += video.GetPlayCount();
        }
        return total;
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
        SayaTubeUser user = new SayaTubeUser("Kholifahdina");

        List<string> filmTitles = new List<string>
        {
            "Review Film Inception oleh Kholifahdina",
            "Review Film Interstellar oleh Kholifahdina",
            "Review Film The Dark Knight oleh Kholifahdina",
            "Review Film Parasite oleh Kholifahdina",
            "Review Film The Matrix oleh Kholifahdina",
            "Review Film Spirited Away oleh Kholifahdina",
            "Review Film Coco oleh Kholifahdina",
            "Review Film Avatar oleh Kholifahdina",
            "Review Film Titanic oleh Kholifahdina",
            "Review Film The Shawshank Redemption oleh Kholifahdina"
        };

        foreach (string title in filmTitles)
        {
            SayaTubeVideo video = new SayaTubeVideo(title);
            video.IncreasePlayCount(new Random().Next(100, 1000)); // Random play count
            user.AddVideo(video);
        }

        // Print semua video yang telah ditambahkan
        user.PrintAllVideoPlaycount();

        // Print detail salah satu video
        Console.WriteLine("\nDetail salah satu video:");
        user.GetTotalVideoPlayCount(); // Menghitung total play count

        // Menampilkan detail video pertama
        Console.WriteLine();
        SayaTubeVideo firstVideo = new SayaTubeVideo(filmTitles[0]);
        firstVideo.PrintVideoDetails();
        Console.ReadLine();
    }
}
