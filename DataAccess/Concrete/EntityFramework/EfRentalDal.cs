using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentACarContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from r in context.Rentals
                             join car in context.Cars
                             on r.CarId equals car.CarId
                             join cu in context.Customers
                             on r.CustomerId equals cu.UserId
                             join b in context.Brands
                             on car.BrandId equals b.BrandId
                             join c in context.Colors
                             on car.ColorId equals c.ColorId
                             join u in context.Users
                             on cu.UserId equals u.Id
                             select new RentalDetailDto
                             {
                                 Id = r.Id,
                                 CarId = car.CarId,
                                 BrandName = b.BrandName,
                                 ColorName = c.ColorName,
                                 UserId = u.Id,
                                 UserName = u.FirstName + " " + u.LastName,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate,
                                 TotalPrice = Convert.ToDecimal(r.ReturnDate.Value.Day - r.RentDate.Day) * car.DailyPrice,
                                 ModelYear = car.ModelYear,
                                 Description = car.Descriptions,

                             };
                return result.ToList();

            }
        }
    }
}
