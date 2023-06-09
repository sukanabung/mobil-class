﻿using System;

class Mobil
{
    // Properties

    public string Warna { get; set; }
    public int JumlahPintu { get; set; }
    public string Merek { get; set; }
    public string Model { get; set; }
    public int TahunKeluaran { get; set; }
    public int KecepatanMaks { get; set; }

    // Constructor
    public Mobil(string wrn, int jmlPintu, string mrk, string mdl, int thn, int kecMaks)
    {
        Warna = wrn;
        JumlahPintu = jmlPintu;
        Merek = mrk;
        Model = mdl;
        TahunKeluaran = thn;
        KecepatanMaks = kecMaks;
    }

    public void Gas(int kecepatan)
    {
        Console.WriteLine("Mobil " + Model + " berjalan dengan kecepatan " + kecepatan + " KM/h");
    }

    public void Klakson()
    {
        Console.WriteLine("Mobil berbunyi : " + "Tinn Tinnn");
    }

    // Method untuk menampilkan informasi mobil
    public void TampilkanInfo()
    {
        Console.WriteLine("Warna: " + Warna);
        Console.WriteLine("Jumlah Pintu: " + JumlahPintu);
        Console.WriteLine("Merek: " + Merek);
        Console.WriteLine("Model: " + Model);
        Console.WriteLine("Tahun Keluaran: " + TahunKeluaran);
        Console.WriteLine("Kecepatan Maksimum: " + KecepatanMaks + " KM/h");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Mobil mobil1 = new Mobil("Merah", 4, "Toyota", "Avanza", 2020, 200);
        mobil1.TampilkanInfo();
        mobil1.Gas(120);
        mobil1.Klakson();
    }
}
