using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //İhtiyaç kredisi
    class PersonalFinanseCreditManager : ICreditManager
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Calculate()
        {
            Console.WriteLine("İhtiyaç kredisi ödeme planı hesaplandı.");
        }
    }
}
