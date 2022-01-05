using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        //ıproductdal sen bir ıentityrepositorysin çalışma tipin product.Sen ıentityrepositoryi product için yapılandırdın.
        /*
        //e-ticaret sisteminde ürünlerin listelendiğini düşün
        //data accesse ürün ekliycez ürün listeliycez ürün nerede entitieste.başka bir katmanı kullanmak istiyorsan referans verirsin.
        List<Product> GetAll();
        //ürünlerin hepsini getir ve listele.
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);

        //ürünleri kategoriye göre filtrele
        List<Product> GetAllByCategory(int categoryId);
        */

        List<ProductDetailDto> GetProductDetails();

    }
}
