//using System;

//class HaloGeneric
//{
//    public void SapaUser<T>(T user)
//    {
//        Console.WriteLine($"Halo user {user}");
//        Console.ReadLine();
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        HaloGeneric halo = new HaloGeneric();
//        halo.SapaUser("Dina"); // Ganti dengan nama panggilan praktikan
//    }
//}

using System;

namespace GenericExample
{
    // Kelas generic untuk menyimpan data
    class DataGeneric<T>
    {
        private T data;

        // Konstruktor dengan parameter data
        public DataGeneric(T data)
        {
            this.data = data;
        }

        // Method untuk mencetak data
        public void PrintData()
        {
            Console.WriteLine($"Data yang tersimpan adalah: {data}");
        }
    }

    class Program
    {
        static void Main()
        {
            // Memasukkan NIM sebagai data generik
            DataGeneric<string> dataNIM = new DataGeneric<string>("2211104004"); // Ganti dengan NIM kamu

            // Memanggil method PrintData
            dataNIM.PrintData();

            // Mencegah console langsung tertutup
            Console.WriteLine("\nTekan ENTER untuk keluar...");
            Console.ReadLine();
        }
    }
}
