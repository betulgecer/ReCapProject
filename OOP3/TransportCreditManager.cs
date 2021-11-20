using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //Taşıt kredisi
    class TransportCreditManager : ICreditManager
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Calculate()
        {
            Console.WriteLine("Taşıt kredisi ödeme planı hesaplandı.");
        }
    }
}
