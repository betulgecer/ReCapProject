using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Concrete
{
    public class StarbucksCustomerManager : Abstract.BaseCustomerManager
    {
        private ICustomerCheckService  _customerCheckService;

        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
                {
                base.Save(customer);
                }
              //CheckIfRealPerson(customer); //mernis doğrulaması bu kişi var mı sistemde yok mu? Senaryo gereği kullanıcı istedi

            else
            {
                throw new Exception("Not a valid person");
            }
        }
    }
}
