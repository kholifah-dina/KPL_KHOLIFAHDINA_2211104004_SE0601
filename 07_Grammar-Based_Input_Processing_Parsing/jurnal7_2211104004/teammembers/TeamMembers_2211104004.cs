using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

class TeamMembers
{
    class Member
    {
        public string NIM { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
    }

    class Team
    {
        public List<Member> Members { get; set; }
    }

    static void Main()
    {
        string filePath = "jurnal7_2_2211104004.json"; // Pastikan file ini ada di direktori proyek

        if (!File.Exists(filePath))
        {
            Console.WriteLine("❌ File JSON tidak ditemukan!");
            return;
        }

        var jsonData = File.ReadAllText(filePath);
        var team = JsonConvert.DeserializeObject<Team>(jsonData);

        if (team?.Members == null || team.Members.Count == 0)
        {
            Console.WriteLine("⚠️ Data kosong atau tidak valid.");
            return;
        }

        Console.WriteLine("\n✅ Team Member List:");
        foreach (var member in team.Members)
        {
            Console.WriteLine($"{member.NIM} - {member.FirstName} {member.LastName} ({member.Age} {member.Gender})");
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadLine();
    }
}
