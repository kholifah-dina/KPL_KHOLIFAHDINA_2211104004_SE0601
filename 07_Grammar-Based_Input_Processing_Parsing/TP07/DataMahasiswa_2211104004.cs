using System;
using System.IO;
using Newtonsoft.Json;

class DataMahasiswa2211104004
{
    public static void ReadJSON(string filePath)
    {
        try
        {
            // Membaca file JSON
            string jsonContent = File.ReadAllText(filePath);

            // Melakukan deserialisasi JSON ke object Mahasiswa
            Mahasiswa data = JsonConvert.DeserializeObject<Mahasiswa>(jsonContent);

            // Menampilkan hasil deserialisasi
            Console.WriteLine($"Nama {data.Nama.Depan} {data.Nama.Belakang} dengan NIM {data.NIM} dari fakultas {data.Fakultas}");
            Console.ReadLine();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Terjadi kesalahan: {ex.Message}");
            Console.ReadLine();
        }
    }
}

// Class untuk menampung data mahasiswa
class Mahasiswa
{
    public NamaLengkap Nama { get; set; }
    public long NIM { get; set; }
    public string Fakultas { get; set; }
}

class NamaLengkap
{
    public string Depan { get; set; }
    public string Belakang { get; set; }
}

// Main method untuk menjalankan program
class Program
{
    static void Main()
    {
        string filePath = "tp7_1_2211104004.json"; // Sesuaikan path jika perlu
        DataMahasiswa2211104004.ReadJSON(filePath);
    }
}
