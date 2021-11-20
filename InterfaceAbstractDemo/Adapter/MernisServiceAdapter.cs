using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using InterfaceAbstractDemo.MernisServiceReference1;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Adapter
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        { 
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikDogrula(customer.NationalityId, customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.DateOfBirth.Year);
        }
    }
}
