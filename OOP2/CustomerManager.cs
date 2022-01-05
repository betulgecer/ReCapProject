using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //İş Sınıfları // business classes -- Manager,service
    class CustomerManager
    {
        //Müşteri işlerimi yapıcağım sınıf operasyon sınıfım
        /*ben burada tüm müşterilerim için işlem yapmak istiyorum.Hem tüzel hem gerçek müşterilerim için o zaman bu classlar müşteri classından miras alıcak.(inheritance)
        müşteride olan herşey tüzel müşteridede,gerçek müşteridede vardır.Müşteri ikisinin ebeveynidir.2 müşteri classımdada id ve müşteri numarası ortak o zaman müşteri 
        classım(ana classıma) bu ikisini atarsam tüzel müşteridede gerçek müşteridede yazmasına gerek kalmayacak çünkü müşteri classında bu özellikler ve bunlar miras alıyor olucak.
        customer classım base class yani temel sınıf demek.Eğer senin base sınıfın varsa o base sınıf referans tutucudur.
        */
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.CustomerNumber + ":müşteri numarası eklendi.");
        }
        public void Update(IndividualCustomer individualcustomer)
        {
            Console.WriteLine(individualcustomer.Name + ":müşteri ismi güncellendi.");
        }
        public void Delete(CorporateCustomer corparatecustomer)
        {
            Console.WriteLine(corparatecustomer.TaxNumber + ":vergi numarası silindi.");
        }
    }
}
