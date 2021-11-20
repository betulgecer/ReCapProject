using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        //biz projeyi çalıştırdığımızda bizim yerimize bir tane bellekte ürün oluşturdu.
        //Sanki bu bize oracle,sql server,postgres,mongodb veritabanlarından geliyormuş gibi simüle ediyoruz.
        List<Product> _products;
        //bu referans tip tek başına bir anlam ifade etmez sadece değişkeni oluşturdu.Projeyi başlatınca bellekte bir tane ürün listesi oluşturalım.
        //Constructor bellekte referans aldığı zaman çalışacak olan blok. Void falan dödürmüyor direk classın ismiyle olunca constructor diyorduk.
        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product{ProductId=1, CategoryId=1, ProductName="Bardak", UnitPrice=15, UnitsInStock=15},
                new Product{ProductId=2, CategoryId=2, ProductName="Kamera", UnitPrice=500, UnitsInStock=3},
                new Product{ProductId=3, CategoryId=3, ProductName="Telefon", UnitPrice=1500, UnitsInStock=2},
                new Product{ProductId=4, CategoryId=4, ProductName="Klavye", UnitPrice=150, UnitsInStock=65},
                new Product{ProductId=5, CategoryId=5, ProductName="Fare", UnitPrice=85, UnitsInStock=1},
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //_products.Remove(product); bu şekilde listeden asla silinmez neden?
            //Arayüzden bir tane ürün newleyip gönderdiğinde bunun referansı diyelim 200 sen ürünler listesinden 200 ü sil diyorsun.
            //Ama 200 yok çünkü oluşturduğun adreslerin referans no ları farklı bu yüzden silmez
            //Burada yapılması gereken (Product product) bunun idsini kullanarak yukardaki adreslerden eşleyen idyi bulup o referansı yakalayacağız.
            //bu sisteme de linq denir LINQ - Language Integrated Query(Dile Gömülü Sorgu)
            //producttodelete silinecek ürünü
            /*
               Product productToDelete = null;
               //ürünleri tek tek dolaşıyoruz.Her dolaştığındaki p o dolaştığın elemana denk gelir
               foreach (var p in _products)
               {
                   //benim gönderdiğim productun productıdsi eşit eşitse o anki productun productidsi ise
                   if (product.ProductId == p.ProductId)
                   {
                       //silinecek eleman o anki bu eleman
                       productToDelete = p;
                   }

               }
               //bu kodu lınq ile çok kısa bir şekilde yazabiliyoruz.
               //singleordefault tek bir eleman bulmaya yarar.bu bizim yerimize ürünleri tek tek dolaşmaya yarar.p tek tek dolaşırken verilen takma isim foreachteki gibi.
               productToDelete = _products.SingleOrDefault(p=> p.ProductId == product.ProductId);
            */
            //linq kullanarak yeni kodumuz
            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);

            _products.Remove(productToDelete);
        }

        //veritabanındaki datayı(List<Product>) businessa vermek lazım.
        //Business ürün listesini istiyorum dediğinde ona bir liste vermek zorundasın.
        //return veri tabanını olduğu gibi döndürüyoruz çünkü tümünü döndürüyoruz
        public List<Product> GetAll()
        {
            return _products;
        }

        public void Update(Product product)
        {
            //gönderilen ürün ıdsine sahip olan listedeki ürünü bul
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId= product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;

        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            //where koşulu içindeki şarta uyan bütün elemanları yeni bir liste haline getirir ve onu döndürür
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }
    }
}
