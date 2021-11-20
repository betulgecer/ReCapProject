using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

//nero ve starbucks iki şirket kahve almak istiyoruz.Starbucksta mernis doğrulaması istiyoruz.Sonra sisteme kaydedicek.
namespace InterfaceAbstractDemo
{
    partial class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager();
            customerManager.Save(new Customer { DateOfBirth = new DateTime(1998,6,13), FirstName = "Betül", LastName = "GEÇER", NationalityId = "61363296196"  }) ;
            Console.ReadLine();
        }
}
    }
