using System;
using System.IO;
using System.Text.Json;

public class Program
{
    public class Address
    {
        public string streetAddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }
    }

    public class Course
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public class Student
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public Address address { get; set; }
        public Course[] courses { get; set; }
    }

    public static void ReadJSON(string filePath)
    {
        try
        {
            // Show where the program is looking for the file
            Console.WriteLine($"Looking for file at: {Path.GetFullPath(filePath)}");

            if (!File.Exists(filePath))
            {
                Console.WriteLine("Error: File not found. Please ensure:");
                Console.WriteLine($"1. The file '{Path.GetFileName(filePath)}' exists");
                Console.WriteLine($"2. It's in this folder: {Path.GetDirectoryName(Path.GetFullPath(filePath))}");
                return;
            }

            string jsonString = File.ReadAllText(filePath);
            Student student = JsonSerializer.Deserialize<Student>(jsonString);

            Console.WriteLine("\n=== Student Data ===");
            Console.WriteLine($"Name: {student.firstName} {student.lastName}");
            Console.WriteLine($"Gender: {student.gender}");
            Console.WriteLine($"Age: {student.age}");

            Console.WriteLine("\n=== Address ===");
            Console.WriteLine($"Street: {student.address.streetAddress}");
            Console.WriteLine($"City: {student.address.city}");
            Console.WriteLine($"State: {student.address.state}");

            Console.WriteLine("\n=== Courses ===");
            foreach (var course in student.courses)
            {
                Console.WriteLine($"{course.code}: {course.name}");
            }
        }
        catch (JsonException)
        {
            Console.WriteLine("Error: Invalid JSON format");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    public static void Main()
    {
        // Using the exact filename you specified
        string jsonFilePath = "jurnal7_1_2211104004.json";
        ReadJSON(jsonFilePath);

        Console.WriteLine("\nPress enter to exit...");
        Console.ReadLine();
    }
}