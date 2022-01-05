using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //Application = Başvuru ; krediye başvuru işlemlerini yapacağımız class
    class ApplicationManager
    {
        //BUrada tek bir kredi istiyorum çünkü artık başvuru yapıcam
        /*METHOD İNJECTİON demek bu metotun(basvuruyap) kullanacağı kredimanagerin ne olacağı yani hangi kredi türü olaacağını ve hangi logla olacağını enjekte ediyoruz.
        Basvuru işlemlerinde asla Hangi kredi türü hangi log olduğu yok.Sadece soyut halleri var ben somut halleriini enjekte ediyorum. */

        public void BasvuruYap(ICreditManager creditManager,ILoggerService loggerService)
        {
            /* Bu şekilde basvuruyap operasyonunda diyelimki taşıt kredisini yazdırdık.O zaman tüm başvuru yapanlar taşıt kredisi üzerinden değerlendirilir.
            Ama basvuruyap metoduna ıcreditmanager interfacemizi çağırıp kredi gibi bir parametre verirsek tüm krediler için hangisi seçilirse onun için işlem yapar bu metot.
            Yani binevi krediyi bağımsız hale getiririz.
           // TransportCreditManager transportCreditManager = new TransportCreditManager();
              transportCreditManager.Calculate();
            */
            creditManager.Calculate();
            loggerService.Log(); //hangi loggerservice gönderilmişse onu logla
            //mesela sonradan farklı bir kredide (esnaf) ekleyebiliyorum,logda ekleyebiliyorum çünkü interfacelerim metotlarım bunu sağlıyor bana.
            /*diyelimki esnaf kredisi için hem veritabanına loglansın hem sms gönderilsin.O zaman Kredionbilgilendirme metodunda nasıl kredi seçmemizi,karşılaştırmamızı sağlayabiliyorsa listeler sayesinde
            buradada liste oluşturup program.cs de list şeklinde çağırıp istediklerimizi orada yazdırabiliriz.
            */

            // ben buraya taşıt kredisi gönderirsem belllekteki taşıt kredisinin hesaplaması çalışır.
            //burada tek bir kredi var onu çağırıyor onun hesaplamasını çağırtıyor.Aşağıda ise bir liste var herbirini tek tek dolaş hesapla diyor.
        }

        //Burada da ön bilgilendirme istiyorum birden fazla kredinin hesabını yapıcam.
        // Aynı veri türünde belirli sayıda ve o sayıda belirsizse bir veri grubu oluşturmak için koleksiyonlar(List<istediğin veri tipi>)kullanılır. krediler parametre
        public void KrediOnBilgilendirmesiYap(List<ICreditManager> credits)
        {
            //listedeki herbir kredinin hesabını yap,listeyi gezicek ya tüm krediler foreach kullandık
            foreach (var credit in credits)
            {
                credit.Calculate();

            }
        }


    }
}
