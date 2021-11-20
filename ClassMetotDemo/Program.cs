using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Class oluşturuyoruz.
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Tc = 123345678912;
            musteri1.Ad = "Betül";
            musteri1.Soyad = "Geçer";
            musteri1.Mail = "gecer@gmail.com";
            musteri1.Sehir = "İstanbul";
            musteri1.Telefon = 05431587421;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Tc = 21987654321;
            musteri2.Ad = "Sedat";
            musteri2.Soyad = "Kaya";
            musteri2.Mail = "kaya@gmail.com";
            musteri2.Sehir = "İstanbul";
            musteri2.Telefon = 05348514712;

            //Dizimizi tanımlıyoruz.
            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.Ad);
                Console.WriteLine(musteri.Soyad);
                Console.WriteLine(musteri.Mail);
                Console.WriteLine(musteri.Sehir);
                Console.WriteLine(musteri.Telefon);
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Listele(musteri2);
            musteriManager.Silme(musteri1);

            Console.ReadLine();
        }
    }
}
