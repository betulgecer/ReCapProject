using System;

class ClassProduct
{
    public static void Main(string[] args)
    {
        Console.Write("  Ürünlerimiz\n----------------\n");

        //ürünlerimizin özelliklerini tanımlıyoruz
        Product product1 = new Product();
        product1.UrunAdi = "İspanyol Paça Pantolon";
        product1.Fiyat = 70;
        product1.Kategori = "Pantolon\n";

        Product product2 = new Product();
        product2.UrunAdi = "Puantiyeli Siyah Elbise";
        product2.Fiyat = 100;
        product2.Kategori = "Elbise\n";

        Product product3 = new Product();
        product3.UrunAdi = "Ekru Yüksel Bel Mom Jeans";
        product3.Fiyat = 90;
        product3.Kategori = "Pantolon\n";

        //Product isimli dizimize ürünlerimizi atıyoruz
        Product[] urunler = new Product[] { product1, product2, product3 };

        //foreach döngüsüyle ürünlerimizin bütün özelliklerini gösteriyoruz
        foreach (var Urun in urunler)
        {
            Console.Write(Urun.UrunAdi + ":" + Urun.Fiyat + ":" + Urun.Kategori);
        }

        Console.Write("---------------\n");

        //for döngüsüyle ürünlerin kategorilerini gösteriyoruz
        for (int i = 0; i < urunler.Length; i++)
        {
            Console.Write(urunler[i].Kategori);
        }

        Console.Write("---------------\n");

        //while döngüsüyle ürünlerin fiyatlarını gösteriyoruz
        int u = 0;
        while (u < urunler.Length)
        {
            Console.Write(urunler[u].Fiyat);
            Console.Write("\n");
            u++;
        }
    }
}

class Product
{
    public string UrunAdi { get; set; }
    public int Fiyat { get; set; }
    public string Kategori { get; set; }

}

