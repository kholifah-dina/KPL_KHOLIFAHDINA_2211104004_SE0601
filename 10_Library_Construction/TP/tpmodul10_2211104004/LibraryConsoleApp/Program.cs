using System;
using AljabarLibraries;

namespace AljabarConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] hasilKuadrat = Aljabar.HasilKuadrat(new double[] { 2, -3 });
            Console.WriteLine("Hasil kuadrat dari 2x - 3:");
            Console.WriteLine($"Output: {{{hasilKuadrat[0]}, {hasilKuadrat[1]}, {hasilKuadrat[2]}}}");

            double[] akar = Aljabar.AkarPersamaanKuadrat(new double[] { 1, -3, -10 });
            Console.WriteLine("\nAkar-akar dari x^2 - 3x - 10:");
            Console.WriteLine($"Output: {{{akar[0]}, {akar[1]}}}");
        }
    }
}
