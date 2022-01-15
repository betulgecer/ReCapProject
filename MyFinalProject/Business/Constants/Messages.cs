using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    //sürekli newlemeyeyim, burası sabit olduğundan static
    //Static dediğimizde newlemiyoruz message. diyoruz uygulama hayatı boyunca tek instance oluyor.
    public class Messages
    {
        public static string ProductAdded = "Ürün eklendi" ;
        public static string ProductNameInvalid= "Ürün ismi geçersiz" ;
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string ProductsListed = "Ürünler Listelendi";    
    }
}
