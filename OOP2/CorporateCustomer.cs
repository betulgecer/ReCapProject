using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class CorporateCustomer : Customer
    {
        public string CompanyName { get; set; } //Şirket adı
        public string TaxNumber { get; set; } //Vergi numarası
    }
}
