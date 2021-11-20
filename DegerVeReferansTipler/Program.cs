using System;
using System.Collections.Generic;
using System.Text;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            //bellekte iki tane yerimiz var stack ve heap
            //değer tipler sadece stackte çalışıyor.
            //sayilar1 dizisinde mesela sayilar1 i stackte başlattın new dediği anda sayilar1 değerleri dizisi heape atıyor.
            //new demek bellekte bir adrs oluştur,heapte bir adres oluştur demek
            //değer tiplerde değer atıyorsun,referans tiplerde adres atıyorsun
            //C dilinde pointer aynı mantık
            //int,decimal,double,float,bool,... --değer tip
            //array,class,interface --referans tip
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 ?? 30

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0] ?? 999
        }
    }
}
