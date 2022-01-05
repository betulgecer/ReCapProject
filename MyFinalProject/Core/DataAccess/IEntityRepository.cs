using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        //jeneric repository nesnelerinde genellikle liste,add,update,silme ve ıd ye göre getirme olur.
        /*datanın tamamını değil de belli bir kısmını getirmek istediğimizde product managerde en sonda GetAll da 
        return _productDal.GetAll(p=>p.CategoryId == 2); böyle bir filtre vermemizi sağlayan yapının ismi EXPRESSİON dır. Linqle gelir
        Yani kategoriye göre getir,ürünün fiyatına göre getir gibi ayrı ayrı metotlar yazmak gerekmiyor.
        */
        List<T> GetAll(Expression<Func<T,bool>> filter=null);

        /*tek bir data getirmek için;bu genelliklle bir şeyin detayına gitmek için mesela bir bankacılık uygulamasında 
        hesaplar var GetAll la liste olarak geliyor, bir tane hesaba tıklayıp detayına iniyoruz Get o zamanda
        */
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
