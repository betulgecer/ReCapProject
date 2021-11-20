using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1, BrandId=1, ColorId=1, ModelYear="1997", DailyPrice=20000, Description="Klasik Araç" },
                new Car{Id=2, BrandId=2, ColorId=2, ModelYear="2015", DailyPrice=63000, Description="İkinci El Araç" },
                new Car{Id=3, BrandId=3, ColorId=3, ModelYear="2021", DailyPrice=250000, Description="Sıfır Araç" },
                new Car{Id=4, BrandId=4, ColorId=4, ModelYear="2006", DailyPrice=46000, Description="İkinci El Araç" },
                new Car{Id=5, BrandId=5, ColorId=5, ModelYear="1999", DailyPrice=38000, Description="Klasik Araç" },
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);

        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetByld(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}