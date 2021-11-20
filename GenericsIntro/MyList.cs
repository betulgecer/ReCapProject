using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        //constructor
        //classı newlersen constructor otomatik çalışır.
        public MyList()
        {
            items = new T[0];
        }
        //T istediğim tip;ben sana t olarak ne verirsem istediğim elemanın türü de o dur.
        //item : eleman
        //add in içerisine elemanları eklemek istiyorum ama eklemek için bir arrayin newlenme zorunluluğu var.Array referans tip olduğu için newlenme zorunluluğu var.
        //Başladığında newlemek istiyorum ama başladığında 0 eleman olarak newlemek istiyorum.
        //Bir class newlendiğinde çalışan bloğa constructor denir.
        public void Add(T item)
        {
            //Dizimin eleman sayısını 1 arttırıcam o zaman newlemek zorundasın.
            //items = new T[1]; böyle yazarsak eleman sayısı hep 1 olur.
            //diyelimki 1 eleman ekledik "engin" sonra gitti eleman sayısını 1 arttırınca 2 eleman oldu ama newleme işlemi yaptığımız için "engin" gitti.Giden referans numarası.
            //o yüzden o referansı birine tutturmamız lazım. gecicidizi = tempArray
            T[] tempArray = items;
            items = new T[items.Length + 1];
            //sana verdiğim emanet elemanı geri versene
            //tempArrayin bütün elemanlarını items a geri atıycaz.
            for (int i = 0; i < tempArray.Length; i++)
            {
                //benim itemsımın i. elemanı = tempArrayden gelen geçici olarak verdiğğim i.elemanı
                items[i] = tempArray[i];
            }
            //tempArray : 5 kutu var B,S,E,A,O
            //items : 1 eleman daha ekledik 6 kutu.İlk 5 kutu boş,tempArrayi geçici tuttuk

            items[items.Length - 1] = item; 

        }
    }
}
