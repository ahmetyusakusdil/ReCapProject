using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {
            var result = _rentalDal.GetAll(c => c.CarId==rental.CarId && c.ReturnDate==null);
            if(result.Count>0)
            _rentalDal.Add(rental);
             return new SuccessResult(Message.RentalAdded);
        }
           

        

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Message.RentalDeleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
           
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(),Message.RentalListed);
        }

        public IDataResult<Rental> GetById(int id)
        {
            _rentalDal.Get(c => c.RentId == id);
            return new SuccessDataResult<Rental>(Message.RentalListed);
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Message.RentalUpdated);
        }
    }
}
