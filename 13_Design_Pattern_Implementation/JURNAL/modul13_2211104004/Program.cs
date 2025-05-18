using System;

class Program
{
    static void Main(string[] args)
    {
        // Buat dua objek singleton
        var data1 = PusatDataSingleton.GetDataSingleton();
        var data2 = PusatDataSingleton.GetDataSingleton();

        // Tambahkan nama anggota kelompok dan asisten praktikum ke data1
        data1.AddSebuahData("Kholifahdina");
        data1.AddSebuahData("Anggota 1");
        data1.AddSebuahData("Anggota 2");
        data1.AddSebuahData("Asisten: Kak Adit");

        // Cetak data dari data2
        Console.WriteLine("Isi data2:");
        data2.PrintSemuaData();

        // Hapus nama asisten dari data2
        data2.HapusSebuahData(3); // Asumsikan index 3 adalah "Kak Adit"

        // Cetak data dari data1
        Console.WriteLine("\nIsi data1 setelah penghapusan:");
        data1.PrintSemuaData();

        // Cetak jumlah data dari data1 dan data2
        Console.WriteLine($"\nJumlah data di data1: {data1.GetSemuaData().Count}");
        Console.WriteLine($"Jumlah data di data2: {data2.GetSemuaData().Count}");
    }
}
