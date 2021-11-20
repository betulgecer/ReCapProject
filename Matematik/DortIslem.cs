using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    class DortIslem
    {
        //parametrede tipini ve işlem yapacak ismi yazarız int tip,sayi1 işlem yapılacak ad metotta parantez içine yazılır
        public void Topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Sonuç :" + toplam);
        }
    }
}
