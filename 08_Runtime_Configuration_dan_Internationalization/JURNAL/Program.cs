using System;

class Program
{
    static void Main()
    {
        var config = BankTransferConfig.LoadConfig("bank_transfer_config.json");

        Console.WriteLine(config.lang == "en" ? "Please insert the amount of money to transfer:" : "Masukkan jumlah uang yang akan di-transfer:");
        int amount = int.Parse(Console.ReadLine());

        int fee = (amount <= config.transfer.threshold) ? config.transfer.low_fee : config.transfer.high_fee;
        int total = amount + fee;

        Console.WriteLine(config.lang == "en" ? $"Transfer fee = {fee}" : $"Biaya transfer = {fee}");
        Console.WriteLine(config.lang == "en" ? $"Total amount = {total}" : $"Jumlah total = {total}");

        Console.WriteLine(config.lang == "en" ? "Select transfer method:" : "Pilih metode transfer:");
        for (int i = 0; i < config.methods.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {config.methods[i]}");
        }
        int methodChoice = int.Parse(Console.ReadLine());

        Console.WriteLine(config.lang == "en" ? "Please type " + config.confirmation.en + " to confirm the transaction:" :
                                                "Ketik " + config.confirmation.id + " untuk mengkonfirmasi transaksi:");
        string confirmInput = Console.ReadLine();

        bool isConfirmed = (config.lang == "en" && confirmInput.ToLower() == config.confirmation.en.ToLower()) ||
                           (config.lang == "id" && confirmInput.ToLower() == config.confirmation.id.ToLower());

        if (isConfirmed)
        {
            Console.WriteLine(config.lang == "en" ? "The transfer is completed." : "Proses transfer berhasil.");
        }
        else
        {
            Console.WriteLine(config.lang == "en" ? "Transfer is cancelled." : "Transfer dibatalkan.");
        }
    }
}
