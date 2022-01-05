using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        //ben sana bir tane categoryıd vereyim sen bana ilgili kategoriyi ver
        //id ye göre çekeceği için tek bir kategori o yüzden Categori sadece List değil
        Category GetById(int categoryId);
    }
}
