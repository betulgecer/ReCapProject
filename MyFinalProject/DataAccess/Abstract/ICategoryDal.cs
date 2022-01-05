using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICategoryDal:IEntityRepository<Category>
    {
        /*
        /*Product gibi Category nesnesini de yazdık.Veriden geliyormuş gibi kategori listesi oluşturduk.Operasyonlarını yazdık.Kategoriye göre 
        filtreleme işlemi yaptık.Aynı productaki gibi. Değişen tek şeyin Listin veya operasyonların parantez içlerinin değiştiğini gördük yani 
        product veya category. Bu şekilde bir sürü tablomuz,varlığımız olduğunu düşün her nesne için aynı işlemler yapmak yerine jeneric yapısını 
        kullanabiliriz.Çünkü sadece tip değişiyor.Bunun yerine bir tane interface yapsak jeneric tipi olsa IproductDal daki product nesnesi veya
        IcategoryDal daki category yerine jeneric T yapsak daha kolay olur. Bu yapının adı da Generics Repository Design Pattern.(Jenerik Repository Tasarım Deseni)
        *
        *
        List<Category> GetAll();
        //ürünlerin hepsini getir ve listele.
        void Add(Category category);
        void Update(Category category);
        void Delete(Category category);

        //ürünleri kategoriye göre filtrele
        List<Category> GetAllByCategory(int categoryId);
        */

    }
}
