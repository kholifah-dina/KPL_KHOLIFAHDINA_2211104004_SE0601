<<<<<<< HEAD
﻿using System;

class Penjumlahan
{
    // Method generic untuk menjumlahkan tiga angka
    public T JumlahTigaAngka<T>(T angka1, T angka2, T angka3)
    {
        dynamic a = angka1;
        dynamic b = angka2;
        dynamic c = angka3;
        return a + b + c;
    }
}

=======
﻿//using System;

//class Penjumlahan
//{
//    // Method generic untuk menjumlahkan tiga angka
//    public T JumlahTigaAngka<T>(T angka1, T angka2, T angka3)
//    {
//        dynamic a = angka1;
//        dynamic b = angka2;
//        dynamic c = angka3;
//        return a + b + c;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Penjumlahan penjumlahan = new Penjumlahan();

//        // Menggunakan tipe data double karena NIM berakhiran 4
//        double angka1 = 12.0, angka2 = 34.0, angka3 = 56.0;
//        double hasil = penjumlahan.JumlahTigaAngka(angka1, angka2, angka3);

//        Console.WriteLine($"Hasil penjumlahan (double): {hasil}");
//        Console.ReadLine();
//    }
//}



using System;
using System.Collections.Generic;

class SimpleDataBase<T>
{
    // Property untuk menyimpan data generic
    public List<T> StoredData { get; private set; }

    // Property untuk menyimpan waktu input data
    public List<DateTime> InputDates { get; private set; }

    // Konstruktor untuk inisialisasi list kosong
    public SimpleDataBase()
    {
        StoredData = new List<T>();
        InputDates = new List<DateTime>();
    }

    // Method untuk menambahkan data baru
    public void AddNewData(T data)
    {
        StoredData.Add(data);
        InputDates.Add(DateTime.UtcNow); // Menyimpan waktu dalam format UTC
    }

    // Method untuk menampilkan semua data yang tersimpan
    public void PrintAllData()
    {
        for (int i = 0; i < StoredData.Count; i++)
        {
            Console.WriteLine($"Data {i + 1} berisi: {StoredData[i]}, yang disimpan pada waktu UTC: {InputDates[i]}");
        }
    }
}

// Program Utama
>>>>>>> implementasi-generic-class
class Program
{
    static void Main()
    {
<<<<<<< HEAD
        Penjumlahan penjumlahan = new Penjumlahan();

        // Menggunakan tipe data double karena NIM berakhiran 4
        double angka1 = 12.0, angka2 = 34.0, angka3 = 56.0;
        double hasil = penjumlahan.JumlahTigaAngka(angka1, angka2, angka3);

        Console.WriteLine($"Hasil penjumlahan (double): {hasil}");

        // Mencegah console langsung tertutup
        Console.WriteLine("\nTekan ENTER untuk keluar...");
=======
        // NIM berakhiran 4 → gunakan tipe data double
        SimpleDataBase<double> database = new SimpleDataBase<double>();

        // Menambahkan tiga angka (misalnya 12, 34, 56 dari NIM)
        database.AddNewData(12.0);
        database.AddNewData(34.0);
        database.AddNewData(56.0);

        // Menampilkan semua data
        Console.WriteLine("Data yang tersimpan:");
        database.PrintAllData();
>>>>>>> implementasi-generic-class
        Console.ReadLine();
    }
}
