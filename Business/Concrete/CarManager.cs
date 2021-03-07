using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
           
        }


        public IResult Add(Car car)
        {
            if (car.DailyPrice<=0)
            {
                return new ErrorResult(Message.CarNotAdded);
            }
            _carDal.Add(car);
            return new SuccessResult(Message.CarAdded);
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Message.CarDeleted); 
        }

        public IDataResult<Car> Get(int Id)
        {
            var g = _carDal.Get(c => c.CarId == Id);
            if (g.CarId!=Id)
            {
                return new ErrorDataResult<Car>(Message.CarNotListed);
            }
           return new SuccessDataResult<Car>( _carDal.Get(c => c.CarId == Id),Message.CarListed);
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>( _carDal.GetAll(),Message.CarListed);
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
           
           return new SuccessDataResult<List<CarDetailDto>>( _carDal.GetCarDetails());
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.BrandId == id));
        }

        public IDataResult<List<Car>> GetCarsByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>( _carDal.GetAll(c => c.ColorId == id));
        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Message.CarUpdated);
        }
    }
}
