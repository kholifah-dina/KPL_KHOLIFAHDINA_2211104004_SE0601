using System;
using System.Collections.Generic;
\ class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        if (title == null) throw new ArgumentNullException("Title tidak boleh null");
        if (title.Length > 200) throw new ArgumentException("Title tidak boleh lebih dari 200 karakter");

        Random random = new Random();
        this.id = random.Next(10000, 99999); // Generate random 5-digit ID
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        if (count < 0) throw new ArgumentException("Play count tidak boleh negatif");
        if (count > 25000000) throw new ArgumentException("Maksimal play count per panggilan adalah 25.000.000");

        checked
        {
            try
            {
                playCount += count;
            }
            catch (OverflowException)
            {
                Console.WriteLine("Terjadi overflow saat menambah play count");
            }
        }
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine($"ID: {id}");
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Play Count: {playCount}");
        Console.WriteLine();
    }
}

class SayaTubeUser
{
    private int id;
    private List<SayaTubeVideo> uploadedVideos;
    public string Username { get; private set; }

    public SayaTubeUser(string username)
    {
        if (username == null) throw new ArgumentNullException("Username tidak boleh null");
        if (username.Length > 100) throw new ArgumentException("Username tidak boleh lebih dari 100 karakter");

        Random random = new Random();
        this.id = random.Next(10000, 99999);
        this.Username = username;
        this.uploadedVideos = new List<SayaTubeVideo>();
    }

    public void AddVideo(SayaTubeVideo video)
    {
        if (video == null) throw new ArgumentNullException("Video tidak boleh null");
        uploadedVideos.Add(video);
    }

    public int GetTotalVideoPlayCount()
    {
        int totalPlayCount = 0;
        foreach (var video in uploadedVideos)
        {
            totalPlayCount += video.playCount;
        }
        return totalPlayCount;
    }

    public void PrintAllVideoPlaycount()
    {
        Console.WriteLine($"User: {Username}");
        for (int i = 0; i < uploadedVideos.Count && i < 8; i++)
        {
            Console.WriteLine($"Video {i + 1} judul: {uploadedVideos[i].title}");
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
            "Review Film Spirited Away oleh Kholifahdina",
            "Review Film The Matrix oleh Kholifahdina",
            "Review Film Fight Club oleh Kholifahdina",
            "Review Film Joker oleh Kholifahdina",
            "Review Film Titanic oleh Kholifahdina",
            "Review Film Avatar oleh Kholifahdina"
        };

        foreach (var title in filmTitles)
        {
            try
            {
                SayaTubeVideo video = new SayaTubeVideo(title);
                user.AddVideo(video);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        user.PrintAllVideoPlaycount();

        // Uji overflow play count
        SayaTubeVideo testVideo = new SayaTubeVideo("Test Video");
        try
        {
            for (int i = 0; i < 10; i++)
            {
                testVideo.IncreasePlayCount(int.MaxValue);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        Console.ReadLine(); // Agar console tidak langsung tertutup
    }
}
