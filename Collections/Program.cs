using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Documents;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string[] isimler = new string[] { "Betül", "Sedat", "Ada", "Ozan" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);

            //isimler dizimizi 4 eleman olarak belirleyip çağırdık ama sonradan bir eleman daha tanımlamak istiyoruz.
            //5 elemanlı bir dizi tanımladık.Bu diziyin çalıştırdığımızda ilker ismi gelir ama dizinin 0. indisi yani 1.eleamanı gelmez.
            //Çünkü new diyerek yeni bir dizi tanımladık 5 elemanlı 4 elemana yani 3.indise ismi ilker dedik ama 0. indis yani 1.eleman,2,4 elemanlar boş.
            //Yukardaki diziye gidip ilker yazmamızın sebebi büyük bir projede bunlar veri olarak alındığı için sonradan ekleme gibi durumun olmaz.
            //4 elemanlı diziyi 5 elemanlı yapamayız bunun için yeniden dizi tanımlamamız gerekir.new dediğimiz anda yeni adres tanımlanır.
            //Bu yüzden dizilerle çalışamıyoruz bu tarz kısımlarda.Bunun yerine koleksiyonları kullanırız.
            isimler = new string[5];
            isimler[4] = "İlker";
            Console.WriteLine(isimler[4]);
            Console.WriteLine(isimler[0]);
            */

            //koleksiyonlarda arrayler gibi değerleri kaybetmemizi engelleyecek bir altyapı var.
            List<string> isimler2 = new List<string> {"Betül", "Sedat", "Ada", "Ozan"};
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
        }
    }
}
