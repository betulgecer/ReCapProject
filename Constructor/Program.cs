using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Customer customer = new Customer();
               {
                customer.Id = 1;
                customer.FirstName = "Betül";
                customer.LastName = "Geçer";
                customer.City = "İstanbul";
               }
            İki türlü de yazılabilir

            */

            Customer customer = new Customer { Id = 1, FirstName="Betül", LastName="Geçer", City="İstanbul" };
            Customer customer2 = new Customer(2, "Sedat", "Kaya", "İstanbul");

            Console.WriteLine(customer2.FirstName);

           // Method(2, "Sedat", "Kaya", "İstanbul");
            
        }

       /* static void Method(int id, string firstName, string lastName, string city)
        {
            Bir methodun çalışma mantığını gösterdik.Method tanımlıyorsun, typenı adını yazıyorsun,mainde çağırıp değerini veriyorsun.
        }
       */

        class Customer
        {
            //burada parametre vermediğimiz için customer1 burada çalıştı
            public Customer()
            {
                //default constructor
                //parametresi olmayan constructora default constructor denir
                //ben bu bloğu yazdım veya yazmadım hiçbir şey farketmez.
                //Varsa benim yazdığım çalışır yoksa default constructor arka planda olan  çalışır.
                Console.WriteLine("Yapıcı blok çalıştı"); //çalışır bu yazı yazar.

            }

            //Burada parametre verdiğimiz için customer2 de burada çalıştı
            //Method parametreleri camelcase yazılır ilk harf küçük sonraki büyük firstName gibi
            public Customer(int id, string firstName, string lastName, string city)
            {
                //burada değerlerini atamazsak mainde yazdırsak bile gelmez
                Id = id;
                FirstName = firstName;
                LastName = lastName;
                City = city;
            }
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string City { get; set; }
        }
    }
}
