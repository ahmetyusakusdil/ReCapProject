using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        IBrandDal _brandDal;
        ICarDal _carDal;
        public CarManager(ICarDal carDal , IBrandDal brandDal)
        {
            _carDal = carDal;
            _brandDal = brandDal;
        }


        public void Add(Car car)
        {
            var d = _brandDal.Get(c => c.BrandId == car.BrandId);
            
                if (d.BrandName.Length > 2 && car.DailyPrice > 0)
                {

                    _carDal.Add(car);
                    Console.WriteLine("Car added");
                }
                else
                {
                    Console.WriteLine("Car not added");

                }
            
                

            
                 
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }
    }
}
