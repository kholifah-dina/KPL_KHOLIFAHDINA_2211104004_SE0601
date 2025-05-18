using System;

namespace GenericExample
{
    // Generic class to store data
    public class DataGeneric<T>
    {
        private T _data;

        // Constructor with data parameter
        public DataGeneric(T data)
        {
            _data = data;
        }

        // Method to print stored data
        public void PrintData()
        {
            Console.WriteLine($"Data yang tersimpan adalah: {_data}");
        }
    }

    public class Program
    {
        public static void Main()
        {
            // Instantiate generic data with NIM
            var dataNim = new DataGeneric<string>("2211104004"); // Ganti dengan NIM kamu

            // Call method to print data
            dataNim.PrintData();

            // Prevent console from closing immediately
            Console.WriteLine("\nTekan ENTER untuk keluar...");
            Console.ReadLine();
        }
    }
}
