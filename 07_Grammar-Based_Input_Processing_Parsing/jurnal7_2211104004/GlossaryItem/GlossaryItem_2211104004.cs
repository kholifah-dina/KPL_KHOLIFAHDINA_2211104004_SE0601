using System;
using System.IO;
using System.Text.Json;

class Program
{
    public class GlossDef
    {
        public string para { get; set; }
        public string[] GlossSeeAlso { get; set; }
    }

    public class GlossEntry
    {
        public string ID { get; set; }
        public string SortAs { get; set; }
        public string GlossTerm { get; set; }
        public string Acronym { get; set; }
        public string Abbrev { get; set; }
        public GlossDef GlossDef { get; set; }
        public string GlossSee { get; set; }
    }

    public class GlossList
    {
        public GlossEntry GlossEntry { get; set; }
    }

    public class GlossDiv
    {
        public string Title { get; set; }
        public GlossList GlossList { get; set; }
    }

    public class Glossary
    {
        public string Title { get; set; }
        public GlossDiv GlossDiv { get; set; }
    }

    public class Root
    {
        public Glossary glossary { get; set; }
    }

    static void ReadJSON(string filePath)
    {
        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found: " + filePath);
            return;
        }

        string json = File.ReadAllText(filePath);
        Root data = JsonSerializer.Deserialize<Root>(json);
        GlossEntry entry = data.glossary.GlossDiv.GlossList.GlossEntry;

        Console.WriteLine("GlossEntry Details:");
        Console.WriteLine($"ID: {entry.ID}");
        Console.WriteLine($"SortAs: {entry.SortAs}");
        Console.WriteLine($"GlossTerm: {entry.GlossTerm}");
        Console.WriteLine($"Acronym: {entry.Acronym}");
        Console.WriteLine($"Abbrev: {entry.Abbrev}");
        Console.WriteLine($"GlossDef: {entry.GlossDef.para}");
        Console.WriteLine($"GlossSeeAlso: {string.Join(", ", entry.GlossDef.GlossSeeAlso)}");
        Console.WriteLine($"GlossSee: {entry.GlossSee}");
    }

    static void Main()
    {
        string filePath = "jurnal7_3_2211104004.json";
        ReadJSON(filePath);
    }
}