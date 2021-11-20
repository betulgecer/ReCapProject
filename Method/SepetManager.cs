using System;
using System.Collections.Generic;
using System.Text;

namespace Method
{
    class SepetManager
    {
        //metot oluşturma fonksiyon metot farkı metotta class olayı var 
        //naming convention -- isimlendirme kuralları
        //syntax
        //ekle metotu mesela üründe ne ekleyecek sadece ekle diyerek neyi ekleyecek senin neyi eklemek istediğini metota vermen lazım.Buna parametre denir.
        //Mesela ürün ekleyeceğim Product onun tipi(string gibi) urun ise isimlendirme aşağıda çağıracağım isim
        public void Ekle(Product urun)
        {
            Console.WriteLine("Tebrikler.Sepete eklendi! : " + urun.Adi);
        }

        /*
        public void Ekle2(string urunAdi,string Aciklama ,double fiyat, double stokAdedi)
        {
            Console.WriteLine("Tebrikler.Sepete eklendi! : " + urunAdi + Aciklama + fiyat + stokAdedi);
        }
        */
    }
}
