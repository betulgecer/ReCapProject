using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //İş Sınıfları // business classes -- Manager,service
    class CustomerManager
    {
        //Müşteri işlerimi yapıcağım sınıf operasyon sınıfım
        public void Add(Customer customer)
        {
            /*ben burada tüm müşterilerim için işlem yapmak istiyorum.Hem tüzel hem gerçek müşterilerim için o zaman bu classlar müşteri classından miras alıcak.(inheritance)
            müşteride olan herşey tüzel müşteridede,gerçek müşteridede vardır.Müşteri ikisinin ebeveynidir.2 müşteri classımdada id ve müşteri numarası ortak o zaman müşteri 
            classım(ana classıma) bu ikisini atarsam tüzel müşteridede gerçek müşteridede yazmasına gerek kalmayacak çünkü müşteri classında bu özellikler ve bunlar miras alıyor olucak.
            customer classım base class yani temel sınıf demek.Eğer senin base sınıfın varsa o base sınıf referans tutucudur.
            */
        }
    }
}
