using System;
using System.Collections.Generic;

// Kelas untuk operasi penjumlahan dengan method generic
class Calculator
{
    // Method generic untuk menjumlahkan tiga angka
    public T SumThreeNumbers<T>(T number1, T number2, T number3)
    {
        dynamic a = number1;
        dynamic b = number2;
        dynamic c = number3;
        return a + b + c;
    }
}

// Kelas untuk menyimpan data generic dengan waktu input
class SimpleDatabase<T>
{
    // Menyimpan data generic
    public List<T> StoredData { get; private set; }

    // Menyimpan tanggal/waktu saat data ditambahkan
    public List<DateTime> InputDates { get; private set; }

    // Konstruktor untuk inisialisasi list
    public SimpleDatabase()
    {
        StoredData = new List<T>();
        InputDates = new List<DateTime>();
    }

    // Method untuk menambahkan data baru beserta waktu
    public void AddNewData(T data)
    {
        StoredData.Add(data);
        InputDates.Add(DateTime.UtcNow);
    }

    // Method untuk mencetak seluruh data beserta waktu input
    public void PrintAllData()
    {
        for (int i = 0; i < StoredData.Count; i++)
        {
            Console.WriteLine($"Data {i + 1} berisi: {StoredData[i]}, yang disimpan pada waktu UTC: {InputDates[i]}");
        }
    }
}

// Program utama
class Program
{
    static void Main()
    {
        // Inisialisasi kalkulator
        var calculator = new Calculator();

        // Contoh penjumlahan tiga angka (tipe data double karena NIM berakhiran 4)
        double number1 = 12.0;
        double number2 = 34.0;
        double number3 = 56.0;

        double result = calculator.SumThreeNumbers(number1, number2, number3);
        Console.WriteLine($"Hasil penjumlahan (double): {result}");

        // Inisialisasi database dan menambahkan data
        var database = new SimpleDatabase<double>();
        database.AddNewData(number1);
        database.AddNewData(number2);
        database.AddNewData(number3);

        // Menampilkan seluruh data
        Console.WriteLine("\nData yang tersimpan:");
        database.PrintAllData();

        // Pause aplikasi sebelum keluar
        Console.WriteLine("\nTekan ENTER untuk keluar...");
        Console.ReadLine();
    }
}
