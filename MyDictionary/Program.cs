using MyDictonary;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary <int, string>  isimler  = new MyDictionary<int, string>();
            isimler.Add(1, "Betül");
            isimler.Add(2, "Sedat");
            isimler.Add(3, "Berat");
            isimler.Add(4, "Faruk");
            isimler.Add(5, "Seher");


            Console.ReadKey();

        }
    }
}
