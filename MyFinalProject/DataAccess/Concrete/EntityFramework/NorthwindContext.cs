using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    //Context : Db tabloları ile proje classlarını bağlamak
    public class NorthwindContext : DbContext
    {
        //benim veritabnım şurada demem gerekmez mi?
        //Entityframework ben nereye bağlanacağım ?
        //bu metod senin veritabanın hangi yer ile ilişkili belirtilecek yer
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = (localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=true");
            //optionsBuilder.UseSqlServer(@"Server = 175.45.2.12"); normal projede böyle IP görürüz.
            //Ama biz development ortamındayız onun yerine viewda sql server object explorerdaki yeri yaz.(localdb)\ mssqllocaldb
            //bu serverda hangi veritabanı ? onu da belirt. Database=Northwind 
            //Trusted_Connection=true : kullanıcı girişimiz yok ya bu veritabanına direk doğrudan giriş gibi.Kullanıcı adlı şifre gerektirmeden.
        }
        //Context hangi veritabanına bağlanacağını buldu yukarıda 
        //Burada ise benim hangi classım hangi tabloya karşılık geliyor ? 
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
