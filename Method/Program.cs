using System;
using System.Collections.Generic;
using System.Text;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            /* string urunAdi1 = "Elma";
             double fiyati1 = 15;
             string aciklama1 = "Amasya Elması";

             string[] meyveler = new string[] { }; */

            Product urun1 = new Product();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Product urun2 = new Product();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Product[] urunler = new Product[] { urun1, urun2 };

            foreach (Product urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-------------");

            }

            Console.WriteLine("---------Metotlar-------");
            //instance - örnek
            //class oluştururken onun bir örneğini oluşturur gibi çağırıyoruz
            //encapsulation -- kapsülleme özellikleri ayrı ayrı yazmak yerine kapsülleme. classta bir özellik tanımlayıp diğer sayfalarda özelliğin çağırması
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            Console.WriteLine("-----------------------");

            /*
            
            //bunlar başka sayfalar olsun diyelimki sen stok adedi diye bir özellik daha ekledin.Bütün sayfalara o özelliği yazmak zorundasın.
            //Classta ise özellik olarak bir kere tanımlarsın her sayfada o gözükür.
            //SepetManager.cs ekle2 metodunda stokAdedi ekledin varsay aşağıdaki tüm sayfalara onu eklemek zorundasın.
            //Bunun yerine Product.cs classa parametreyle eklediğin zaman özellik olarak her yere ekler.
            sepetManeger.Ekle2("Armut", "Yeşil Armut", 12, 45);
            sepetManeger.Ekle2("Elma", "Yeşil Elma", 10, 78);
            sepetManeger.Ekle2("Karpuz", "Yeşil Karpuz", 20, 69);

           */

            Console.ReadLine();
        }
    }
}
