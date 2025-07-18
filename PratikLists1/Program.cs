using System;  // Giriş ve çıkış işlemleri için gerekli kütüphane
using System.Collections.Generic;  // List kullanmak için bu kütüphane gerekir

class Program
{
    static void Main(string[] args)
    {
        // Ziyaretçilerin isimlerini saklayacağımız listeyi oluşturduk
        List<string> davetliler = new List<string>()
        {
            "Bülent Ersoy",
            "Ajda Pekkan",
            "Ebru Gündeş",
            "Hadise",
            "Hande Yener",
            "Tarkan",
            "Funda Arar",
            "Demet Akalın"
        };

        // Başlık yazdırılıyor
        Console.WriteLine("** Davetliler **");

        // Sıra numarası için bir sayaç değişkeni tanımlıyoruz
        int siraNo = 1;

        // Liste içindeki her bir ismi foreach ile tek tek döneriz
        foreach (var isim in davetliler)
        {
            // Her bir ismi sırayla ve numarasıyla birlikte ekrana yazdırıyoruz
            Console.WriteLine($"{siraNo} - {isim}");
            siraNo++;  // Her seferinde sırayı 1 artır
        }
    }
}
