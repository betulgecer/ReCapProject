using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kategoriler için bir tane liste oluşturmak istiyorum,olduğunu varsayalım normalde veri kaynağından gelir datadan
            List<Category> categories = new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Bilgisayar"},
            };

            List<Product> products = new List<Product>
            {
                new Product{ProductId=1, CategoryId=1, ProductName="Acer Laptop", QuantityPerUnit= "32 GB Ram", UnitPrice =10000, UnitsInStock=5},
                new Product{ProductId=2, CategoryId=1, ProductName="Asus Laptop", QuantityPerUnit= "16 GB Ram", UnitPrice =8000, UnitsInStock=3},
                new Product{ProductId=3, CategoryId=1, ProductName="Hp Laptop", QuantityPerUnit= "8 GB Ram", UnitPrice =6000, UnitsInStock=2},
                new Product{ProductId=4, CategoryId=2, ProductName="Samsung Telefon", QuantityPerUnit= "4 GB Ram", UnitPrice =5000, UnitsInStock=15},
                new Product{ProductId=5, CategoryId=2, ProductName="Apple Telefon", QuantityPerUnit= "4 GB Ram", UnitPrice =8000, UnitsInStock=0},
            };
            /* Console.WriteLine("------Algoritmik------");
             foreach (var product in products)
             {
                 if (product.UnitPrice > 5000 && product.UnitsInStock > 3)
                 {
                     Console.WriteLine(product.ProductName);
                 }
             }

             Console.WriteLine("------Linq-------");
             //result=sonuç,p o anki productstaki karşılık gelen eleman takma isim
             var result = products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock > 3);
             foreach (var p in result)
             {
                 Console.WriteLine(p.ProductName);
             }
            BUrayı sağ tıklayım quick seçeneğinde extract method dersek burayı siler ve method oluşturur tüm her yerde o verdiğimiz isimle gözükür.Test
            */
            // Test(products);

            // GetProducts(products);

            /*
             //Any methodu ile bir listenin içinde eleman var mı yok mu onu öğreniriz. Boolean döndürür cevap true ya da false olur.
             var result = products.Any(p=>p.ProductName=="Acer Laptop");
             Console.WriteLine(result);
            */

            //AnyTest(products);
            /*
            //find aranılan kritere uygun nesnenin kendisini verir.
           var result = products.Find(p => p.ProductId == 3);
           Console.WriteLine(result.ProductName);
            */

            //FindTest(products);

            /*
             //Contains = içeriyorsa ürün isminde top kelimesi içeren tüm elemanları getir. Where koşulu gibi findall.Where bir liste dönüyor her yola çekilebilir,Find direk liste dönüyor.
             var result = products.FindAll(p => p.ProductName.Contains("top"));
             Console.WriteLine(result);
            */

            //FindAllTest(products);

            /*
            //İçerisinde top olan ürün adlarını listelesin. Sonuç listedeki sırayla verilir ama ben fiyatına göre artan bir şekilde listelesin desem o zaman orderby.
            //OrderByAscending = Artan(küçükten büyüğe) , OrderByDescending = Düşen (büyükten küçüğe)
            //Fiyatlarda aynı olsun varsayalım bu sefer onları da kendi içlerinde z'den a'ya ters alfabetik sıralasın o zaman then kullanılır.
            var result = products.Where(p=>p.ProductName.Contains("top")).OrderByDescending(p=>p.UnitPrice).ThenByDescending(p=>p.ProductName);
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
            */

            //AscDescTest(products);

            /*
            //LINQ farklı yazılışı select p yeni listeye oluşturuyor.select p normalde.select p.ProductName yazarsak atanacak listeye sadece ürün isimlerini atar ama belli başlı
            //özellikleri atsın istersek class yap.DTO detaylı. Classı çağır burada sonra.
            var result = from p in products
                         where p.UnitPrice > 6000 && p.UnitsInStock > 3 //farklı yazılışta where kullanımı
                         orderby p.UnitPrice descending, p.ProductName ascending //farklı yazılışta orderby kullanımı başka şart yazılabilir
                         select new ProductDto { ProductId = p.ProductId, ProductName = p.ProductName, UnitPrice = p.UnitPrice };
            */

            //ClassicLinqTest(products);

            //productlardaki her bir p ile categorieslerdeki her bir c yi birleşttir.Neye göre? productlardaki categoryid ile categorieslerdeki categoryid ye göre.Where,orderby normal kullanılabilir.
            var result = from p in products
                         join c in categories
                         on p.CategoryId equals c.CategoryId
                         select new ProductDto { ProductId = p.ProductId, CategoryName = c.CategoryName, ProductName = p.ProductName, UnitPrice = p.UnitPrice };
            foreach (var productDto in result)
            {
                Console.WriteLine(productDto.ProductName+ ""+ productDto.CategoryName);
                Console.WriteLine("{0} ------- {1}" , productDto.ProductName, productDto.CategoryName); //böyle de yazılabilir. O a productname 1 e categoryname gelsin demek
            }

        }

        private static void ClassicLinqTest(List<Product> products)
        {
            var result = from p in products
                         where p.UnitPrice > 6000 && p.UnitsInStock > 3 //farklı yazılışta where kullanımı
                         orderby p.UnitPrice descending, p.ProductName ascending //farklı yazılışta orderby kullanımı başka şart yazılabilir
                         select new ProductDto { ProductId = p.ProductId, ProductName = p.ProductName, UnitPrice = p.UnitPrice };
        }

        private static void AscDescTest(List<Product> products)
        {
            var result = products.Where(p => p.ProductName.Contains("top")).OrderByDescending(p => p.UnitPrice).ThenByDescending(p => p.ProductName);
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void FindAllTest(List<Product> products)
        {
            var result = products.FindAll(p => p.ProductName.Contains("top"));
            Console.WriteLine(result);
        }

        private static void FindTest(List<Product> products)
        {
            var result = products.Find(p => p.ProductId == 3);
            Console.WriteLine(result.ProductName);
        }

        private static void AnyTest(List<Product> products)
        {
            var result = products.Any(p => p.ProductName == "Acer Laptop");
            Console.WriteLine(result);
        }

        private static void Test(List<Product> products)
        {
            Console.WriteLine("------Algoritmik------");
            foreach (var product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitsInStock > 3)
                {
                    Console.WriteLine(product.ProductName);
                }
            }

            Console.WriteLine("------Linq-------");
            //result=sonuç,p o anki productstaki karşılık gelen eleman takma isim
            var result = products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock > 3);
            foreach (var p in result)
            {
                Console.WriteLine(p.ProductName);
            }
        }

        // Console.WriteLine("------Algoritmik------");
        static List<Product> GetProducts(List<Product> products)
            {
                List<Product> filteredProducts = new List<Product>();
                foreach (var product in products)
                {
                    if (product.UnitPrice > 5000 && product.UnitsInStock > 3)
                    {
                        Console.WriteLine(product.ProductName);
                    }
                }
                return filteredProducts;
            }

           // Console.WriteLine("------Linq-------");
           static List<Product> GetProductsLinq(List<Product> products)
            {
                //where burada foreach görevi görüyor döngü oluşturuyor,şartlara göre uyanları yeni liste oluşturarak bize veriyor return
                return products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock > 3).ToList();
                //bu bir array aslında IEunamerable demek dönülebilir yapılar demek aslında .ToList dersek onu listeye çevirir
            }
        
    }

    //diyelimki bu classta ProductDto da bir de categoryname olsun ama Product tablosunda categoryname yok o zaman selectte ekleyemem.Yeni listeye atamam. O zaman join yaparız.
    class ProductDto
    {
        public int ProductId { get; set; }

        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }

    }
    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        //Ürün açıklaması
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }
    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }


}
