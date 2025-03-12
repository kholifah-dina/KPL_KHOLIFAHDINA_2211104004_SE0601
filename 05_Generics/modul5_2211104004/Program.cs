using System;

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

class Program
{
    static void Main()
    {
        Penjumlahan penjumlahan = new Penjumlahan();

        // Menggunakan tipe data double karena NIM berakhiran 4
        double angka1 = 12.0, angka2 = 34.0, angka3 = 56.0;
        double hasil = penjumlahan.JumlahTigaAngka(angka1, angka2, angka3);

        Console.WriteLine($"Hasil penjumlahan (double): {hasil}");

        // Mencegah console langsung tertutup
        Console.WriteLine("\nTekan ENTER untuk keluar...");
        Console.ReadLine();
    }
}
