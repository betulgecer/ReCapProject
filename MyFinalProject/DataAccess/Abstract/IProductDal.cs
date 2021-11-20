using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal
    {
        //e-ticaret sisteminde ürünlerin listelendiğini düşün
        //data accesse ürün ekliycez ürün listeliycez ürün nerede entitieste.başka bir katmanı kullanmak istiyorsan referans verirsin.
        List<Product> GetAll();
        //ürünlerin hepsini getir ve listele.
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);

        //ürünleri kategoriye göre filtrele
        List<Product> GetAllByCategory(int categoryId);

    }
}
