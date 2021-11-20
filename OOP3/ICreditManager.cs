using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //Bir interface oluşturduğumuzda o interfacesin içerisindeki operasyonlar alternatif sistemler için bir şablon ve buna ek olarak referans tutucu görevi görüyor.
    //İnterfaceleri birbirinin alternatifi olan ama kod çreikleri farklı olan durumlar için kullanırız.
    interface ICreditManager
    {
        void Calculate();
        void BiseyYap();
    }
    // Eğerki bir sınıf bir interfaceyi (:) böyle kullanıyorsa benim creditmanager kurallarıma uymak zorundasın. O yüzden her kredi(taşıt,konut,ihtiyaç) creditmanager interfacesindeki her metotları içermek zorunda.  
    // Okunurluğu arttırmak için interfaceleri I harfi ile başlatırız interface olduğunu anlayalım diye.

    /*
    class CreditManager
    {
        //calcuşate = hesapla
        public void Calculate()
        {
            //İnterface = Soyutlama
            //Binlerce kredi çeşidi olduğunu düşün 300 tane mesela her kredi için faiz oranı,dosya masrafı,farklı çzellikleri vardır ve birbirinden farklıdır.Sen hesapla metodu için kredi1 buysa şu işlemi yap 
            kredi2 buysa şu işlemi yap gibi if veya switch-case blokları kullanabilirsin.Ama 300 kredi için kod kalabalığıdır.Biz interface yaparak işi kolaylaştırıyoruz.
            /* İmzanın aynı olduğu(hesapla metotu) işte taşıt kredisindede,konut kredisindede,ihtiyaç kredisindede hesaplama işlemi yapılır hepsinin içeriği faiz oranı vs farklıdır.
            Bu durumda imzanın aynı olduğu ama içerisinin farklı olduğu durumlarda  baseda oluşturduğumuz classı (CreditManager) class olarak değilde interface olarak oluştururuz.
             
        }
    }
    */
}

