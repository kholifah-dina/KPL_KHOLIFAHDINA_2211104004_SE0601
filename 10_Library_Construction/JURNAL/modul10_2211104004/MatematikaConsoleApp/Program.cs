using System;
using MatematikaLibraries;

namespace modul10_2211104004
{
    class Program
    {
        static void Main(string[] args)
        {
            Matematika mtk = new Matematika();

            Console.WriteLine("=== FPB dan KPK ===");
            Console.WriteLine($"FPB(60, 45) = {mtk.FPB(60, 45)}");
            Console.WriteLine($"KPK(12, 8) = {mtk.KPK(12, 8)}");

            Console.WriteLine("\n=== Turunan ===");
            int[] persamaanTurunan = { 1, 4, -12, 9 };
            Console.WriteLine($"Turunan dari x^3 + 4x^2 -12x + 9 adalah: {mtk.Turunan(persamaanTurunan)}");

            Console.WriteLine("\n=== Integral ===");
            int[] persamaanIntegral = { 4, 6, -12, 9 };
            Console.WriteLine($"Integral dari 4x^3 + 6x^2 -12x + 9 adalah: {mtk.Integral(persamaanIntegral)}");

            Console.WriteLine("\nTekan sembarang tombol untuk keluar...");
            Console.ReadKey();
        }
    }
}
