using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    //projeden iki hafta sonra yeni nesne oluşturduğunu düşün herşey sıfırdan
    public class Customer:IEntity
    {
        //kullanılan veritabanında customerid string tutuluyor ondan string yazıldı normalde tipi int
        public string CustomerId { get; set; }
        public string ConctactName { get; set; }
        public string CompanyName { get; set; }
        public string City { get; set; }
       
    }
}
