using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Customer customer1 = new Customer();
             customer1.Name = "Betül";
             customer1.Surname = "Geçer";
             customer1.Id = 1;
             customer1.TcNumber = "12345678952";
             customer1.CustomerNumber = "78965";
             customer1.CompanyName = "?";

             //individualcustomer = gerçek (bireysel) müşteri
             //corporatecustomer = tüzel müşteri
             // Burada companyname(şirketadı) yoktur çünkü bu müşteri şahıs bir şirket değildir.
             //Eğer bir nesnede bir değeri kullanmak zorunda değilsen,o nesneye ait gibi duruyorsa o an demekki orada soyutlama hatası yapıyorsun demektir.
             //Gerçek Müşteri - Tüzel Müşteri 2 müşteriymiş gibi düşün birbirinin aynısı değildir birbiri yerine kullanılamaz.MusteriTipi diye bir şey tanımlayalım mesela 1 se gerçek müşteri 0 sa tüzel müşteri olsun.
              Hatalı bir tanım olur çünkü müşteri gerçek bir müşteri gibi görünen ama gerçekte tüzel müşteri olan hatalı veri girişinden kaynaklı datalarla çok karşılaşırız.
             //Burada yukarıdaki tekniği uyguluyoruz.Bu tekniği söyleyen yazılım geliştirme prensiplerinden SOLID dediğimiz L harfidir.
            */

            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNumber = "12345";
            customer1.Name = "Betül";
            customer1.Surname = "Geçer";
            customer1.TcNumber = "123456789";

            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNumber = "54321";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNumber = "123456789";

            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorporateCustomer();
            /* bir yerde new görürsen bu bellekteki referans nosudur.Müşteri classı hem gerçek müşterinin referans numarasını tutabiliyor hem de tüzel müşterinin referans numarasını tutabiliyor.
             * */

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);


        }
    }
}
