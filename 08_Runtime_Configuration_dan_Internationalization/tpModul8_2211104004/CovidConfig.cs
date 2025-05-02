using System;
using System.IO;
using Newtonsoft.Json;

class CovidConfig
{
    public string SatuanSuhu { get; set; } = "celcius";
    public int BatasHariDeman { get; set; } = 14;
    public string PesanDitolak { get; set; } = "Anda tidak diperbolehkan masuk ke dalam gedung ini";
    public string PesanDiterima { get; set; } = "Anda dipersilahkan untuk masuk ke dalam gedung ini";

    public void UbahSatuan()
    {
        SatuanSuhu = (SatuanSuhu.ToLower() == "celcius") ? "fahrenheit" : "celcius";
        Console.WriteLine($"[DEBUG] Satuan suhu telah diubah menjadi: {SatuanSuhu}");
    }

    public bool ValidasiSuhu(double suhu)
    {
        if (SatuanSuhu.ToLower() == "celcius")
        {
            return suhu >= 36.5 && suhu <= 37.5;
        }
        else if (SatuanSuhu.ToLower() == "fahrenheit")
        {
            return suhu >= 97.7 && suhu <= 99.5;
        }
        return false;
    }

    public bool ValidasiHariDeman(int hariDeman)
    {
        return hariDeman < BatasHariDeman;
    }
}

class Program
{
    static void Main()
    {
        try
        {
            CovidConfig config = new CovidConfig();
            Console.WriteLine("=== APLIKASI CEK KESEHATAN ===");

            // Ubah satuan suhu sebelum input
            config.UbahSatuan();

            // Input suhu
            Console.Write($"[INPUT] Berapa suhu badan anda saat ini? Dalam nilai {config.SatuanSuhu}: ");
            string inputSuhu = Console.ReadLine();
            Console.WriteLine($"[DEBUG] Input suhu: {inputSuhu}");

            if (!double.TryParse(inputSuhu, out double suhuBadan))
            {
                Console.WriteLine("[ERROR] Input suhu tidak valid. Harap masukkan angka.");
                return;
            }

            // Input hari demam
            Console.Write("[INPUT] Berapa hari yang lalu (perkiraan) anda terakhir memiliki gejala demam? ");
            string inputHari = Console.ReadLine();
            Console.WriteLine($"[DEBUG] Input hari demam: {inputHari}");

            if (!int.TryParse(inputHari, out int hariDeman))
            {
                Console.WriteLine("[ERROR] Input hari demam tidak valid. Harap masukkan angka.");
                return;
            }

            // Debugging untuk memastikan nilai diterima
            Console.WriteLine($"[DEBUG] Memeriksa validasi suhu dan hari demam...");
            bool suhuValid = config.ValidasiSuhu(suhuBadan);
            bool demamValid = config.ValidasiHariDeman(hariDeman);
            Console.WriteLine($"[DEBUG] Suhu valid: {suhuValid}, Hari demam valid: {demamValid}");

            // Output hasil
            if (suhuValid && demamValid)
            {
                Console.WriteLine(config.PesanDiterima);
            }
            else
            {
                Console.WriteLine(config.PesanDitolak);
            }

            // **Agar konsol tidak langsung tertutup**
            Console.WriteLine("\n[INFO] Tekan tombol apa saja untuk keluar...");
            Console.ReadKey();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[ERROR] Terjadi kesalahan: {ex.Message}");
        }
    }
}
