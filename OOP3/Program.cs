using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*ICreditManager  personalFinanseCreditManager = new PersonalFinanseCreditManager();
            personalFinanseCreditManager.Calculate();
            İnterfacelerde o interface implement eden classın referans numarsını tutabilir.
            */

            PersonalFinanseCreditManager personalFinanseCreditManager = new PersonalFinanseCreditManager();
            //personalFinanseCreditManager.Calculate();

            TransportCreditManager transportCreditManager = new TransportCreditManager();
            //transportCreditManager.Calculate();

            MortgageLoanManager mortgageLoanManager = new MortgageLoanManager();
            // mortgageLoanManager.Calculate();

            //Başvuru işlemlerinin olduğu operasyon sınıfımdaki başvuru yap metodunu çağırıp konut krediai için hesaplama işlemi yaptırdım.Yukarıdakiler gitti bu şekilde oluştur.
            //Ekranda sadece konut kredi hesaplaması yaptı yazar. 
            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.BasvuruYap(mortgageLoanManager,new DatabaseLoggerService());
            /*basvuruyap metodu iki parametre aldı şimdi loglama kısmını da tanımlamalıyım.ister parametreyi böyle içerde yap ister normal tanımla
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            applicationManager.BasvuruYap(mortgageLoanManager,databaseLoggerService);
            */
            List<ICreditManager> credits = new List<ICreditManager>() {personalFinanseCreditManager,transportCreditManager };
            applicationManager.KrediOnBilgilendirmesiYap(credits);

            Console.ReadLine();
        }

    }
}
