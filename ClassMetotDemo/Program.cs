using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args) 
        {
            Musteri musteri1 = new Musteri();
            musteri1.Name = "Mehmet";
            musteri1.Surname = "Balcı";
            musteri1.Old = 46;
            musteri1.Money = 22500;

            Musteri musteri2 = new Musteri();
            musteri2.Name = "Nuran";
            musteri2.Surname = "Zengin";
            musteri2.Old = 50;
            musteri2.Money = 126500;

            Musteri musteri3 = new Musteri();
            musteri3.Name = "Fatih";
            musteri3.Surname = "Balık";
            musteri3.Old = 24;
            musteri3.Money = 12000;

            Musteri musteri4 = new Musteri();
            musteri4.Name = "Selin";
            musteri4.Surname = "Cengiz";
            musteri4.Old = 20;
            musteri4.Money = 267;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };

            Console.WriteLine("Bankamızda  Kayıtlı Müsteri Listesi");
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Name + "  " + musteri.Surname + " " + "Yaşı: "+ musteri.Old + " " + "Bakiyesi :" + musteri.Money);
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri2);
            musteriManager.Sil(musteri1);
        }
    }
}