﻿using System;
using System.Collections.Generic;

public class PusatDataSingleton
{
    private static PusatDataSingleton _instance;
    private List<string> DataTersimpan;

    // Konstruktor privat
    private PusatDataSingleton()
    {
        DataTersimpan = new List<string>();
    }

    // Method untuk mengakses instance
    public static PusatDataSingleton GetDataSingleton()
    {
        if (_instance == null)
        {
            _instance = new PusatDataSingleton();
        }
        return _instance;
    }

    // Mengembalikan semua data
    public List<string> GetSemuaData()
    {
        return DataTersimpan;
    }

    // Menampilkan semua data
    public void PrintSemuaData()
    {
        Console.WriteLine("Data Tersimpan:");
        foreach (string data in DataTersimpan)
        {
            Console.WriteLine("- " + data);
        }
    }

    // Menambahkan satu data
    public void AddSebuahData(string input)
    {
        DataTersimpan.Add(input);
    }

    // Menghapus data berdasarkan index
    public void HapusSebuahData(int index)
    {
        if (index >= 0 && index < DataTersimpan.Count)
        {
            DataTersimpan.RemoveAt(index);
        }
        else
        {
            Console.WriteLine("Index tidak valid.");
        }
    }
}
