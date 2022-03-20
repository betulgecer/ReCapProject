using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<List<Rental>> GetAll();
        IDataResult<List<Rental>> GetRentalsByCarId(int id);
        IDataResult<List<Rental>> GetRentalsByCustomerId(int id);
        IDataResult<Rental> GetById(int Id);
        IDataResult<List<RentalDetailDto>> GetRentalDetails();

        IResult Add(Rental rental);
        IResult Delete(Rental rental);
        IResult Update(Rental rental);
    }
}
