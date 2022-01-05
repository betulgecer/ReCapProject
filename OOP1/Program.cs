using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product { Id = 2, CategoryId = 5, UnitsInStock = 5, ProductName = "Kalem", UnitPrice= 35 };

            Product[] products = new Product[] { product1, product2 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.UnitPrice);
            }

            //PascalCase  //camelCase
            //case sensitive -- küçük büyük harf duyarlı

            ProductManager productManager = new ProductManager();
            productManager.Update(product1);
            productManager.Add(product2);



            /*
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName); //Kamera
            
            int sayi = 100;
            productManager.BiseyYap(sayi)
;
            Console.WriteLine(sayi); //100

            //int,double,bool.. değer tip stack
            //diziler,class,abstract class,interface... referans tip stack,heap
            */

            /*
            //Burda void için topla2 fonksiyonunu değer verip çalıştırdık.
            productManager.Topla2(3, 6);

            //diyelimki topla fonksiyonu çalıştıktan sonra ben çıkan sonucu bi de2 ile çarpmak istiyorum diyelim
            //void te olmaz.Çünkü gitti yaptı bitti işi bu topla fonksiyonu için sayi1,sayi2 diye int tipinde veri belirledik.
            //burda toplamaSonucu diye değişken tanımlayıp topla fonksiyonumuzu burada kullandık.toplamaSonucu değişkenini kodda daha sonra kullanıp 2 ile çarptık.
            //returnde devam özelliği vardır.Topla fonksşyonunu 2.kez kullanılır hale getirdik.
            int toplamaSonucu = productManager.Topla(3, 6);
            Console.WriteLine(toplamaSonucu*2);
            //Console.WriteLine(productManager.Topla(3, 6)* 2);
            */

        }
    }
}
