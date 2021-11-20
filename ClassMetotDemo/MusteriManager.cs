using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        //Metotları oluşturuyoruz
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Ekleme İşlemi");
            Console.WriteLine("---------------");
            Console.WriteLine("Id :" + musteri.Id);
            Console.WriteLine("Tc :" + musteri.Tc);
            Console.WriteLine("Ad :" + musteri.Ad);
            Console.WriteLine("Soyad :" + musteri.Soyad);
            Console.WriteLine("Mail :" + musteri.Mail);
            Console.WriteLine("Şehir :" + musteri.Sehir);
            Console.WriteLine("Telefon numarası :" + musteri.Telefon);
            Console.WriteLine("Tebrikler.Müşteri başarıyla eklendi!");

        }
        public void Listele(Musteri musteri)
        {
            Console.WriteLine("****************");
            Console.WriteLine("Listeleme İşlemi");
            Console.WriteLine("---------------");
            Console.WriteLine("Müşterinin Adını ve Soyadını Göster : " + musteri.Ad + " " + musteri.Soyad);

        }

        public void Silme(Musteri musteri)
        {
            Console.WriteLine("****************");
            Console.WriteLine("Silme İşlemi");
            Console.WriteLine("---------------");
            Console.WriteLine("Müşterinin mail bilgisi silindi : " + musteri.Mail);

        }
    }
}

