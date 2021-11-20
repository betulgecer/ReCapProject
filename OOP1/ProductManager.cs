
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        //ProductManager-ProductService gibi isimler olduğu taktirde ürün classı için anla ki ürünle ilgili operasyonlar var.Ekleme,silme,arama,listeleme,güncelleme vs. vs.Bu classlar bu yüzden oluşur.
        //ProductManager-iş yapan; Product-varlık(entity); Program-Menü

        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "güncellendi.");
        }

         /*
          public void Add(Product product)
          {
              product.ProductName = "Kamera";
          }

          public void BiseyYap(int sayi)
          {
              sayi = 99;
          }
         */

        /*
        //Burda int tipli topla fonksiyonumuzda return mantığını anlayacağız.
        //sayi1,sayi2 döndür diyoruz yani kodda tekrar kullanabiliriz mantığında.Program.cs ye gel.
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        //void emir kipi gibi düşün git yap.Burda sayi1,sayi2 topla dedik.
        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + sayi2);
        }
        */



      
    }
}
