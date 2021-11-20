using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // böyle değil MyList isimler = new MyList();
            //genericte bu şekilde
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Betül");



        }
    }
}
