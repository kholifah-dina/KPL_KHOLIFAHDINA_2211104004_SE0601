using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

class KuliahMahasiswa2211104004
{
	public static void ReadJSON(string filePath)
	{
		try
		{
			// Membaca file JSON
			string jsonData = File.ReadAllText(filePath);

			// Parsing JSON ke JObject
			JObject jsonObject = JObject.Parse(jsonData);

			// Mendapatkan arraydotnet run mata kuliah
			JArray coursesArray = (JArray)jsonObject["courses"];

			Console.WriteLine("Daftar mata kuliah yang diambil:");

			// Loop melalui setiap mata kuliah dan mencetaknya
			for (int i = 0; i < coursesArray.Count; i++)
			{
				string code = coursesArray[i]["code"].ToString();
				string name = coursesArray[i]["name"].ToString();
				Console.WriteLine($"MK {i + 1} {code} - {name}");
				Console.ReadLine();
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine($"Terjadi kesalahan: {ex.Message}");
			Console.ReadLine();
		}
	}

	static void Main()
	{
		string filePath = "tp7_2_2211104004.json"; // Sesuaikan path file JSON
		ReadJSON(filePath);
	}
}
