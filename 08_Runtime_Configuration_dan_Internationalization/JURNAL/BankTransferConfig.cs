using System.Text.Json;
using System.IO;

public class BankTransferConfig
{
    public string lang { get; set; }
    public Transfer transfer { get; set; }
    public List<string> methods { get; set; }
    public Confirmation confirmation { get; set; }

    public class Transfer
    {
        public int threshold { get; set; }
        public int low_fee { get; set; }
        public int high_fee { get; set; }
    }

    public class Confirmation
    {
        public string en { get; set; }
        public string id { get; set; }
    }

    public static BankTransferConfig LoadConfig(string path)
    {
        if (File.Exists(path))
        {
            string jsonString = File.ReadAllText(path);
            return JsonSerializer.Deserialize<BankTransferConfig>(jsonString);
        }
        else
        {
            return new BankTransferConfig
            {
                lang = "en",
                transfer = new Transfer { threshold = 25000000, low_fee = 6500, high_fee = 15000 },
                methods = new List<string> { "RTO (real-time)", "SKN", "RTGS", "BI FAST" },
                confirmation = new Confirmation { en = "yes", id = "ya" }
            };
        }
    }
}
