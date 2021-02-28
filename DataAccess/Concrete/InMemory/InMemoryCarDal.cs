using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
                new Car { CarId=1, BrandId=1 , ColorId=1 , DailyPrice=300000, ModelYear=2018, CarDescription="Benzinli" },
                new Car { CarId=2, BrandId=1 , ColorId=3 , DailyPrice=350000, ModelYear=2019, CarDescription="Dizel" },
                new Car { CarId=3, BrandId=2 , ColorId=2 , DailyPrice=400000, ModelYear=2021, CarDescription="Dizel" },
                new Car { CarId=4, BrandId=2 , ColorId=4 , DailyPrice=450000, ModelYear=2020, CarDescription="Benzinli" },
                new Car { CarId=5, BrandId=3 , ColorId=1 , DailyPrice=200000, ModelYear=2015, CarDescription="Benzinli" }
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);

            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        { 
            return _cars;
              
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int Id)
        {
           return _cars.Where(c => c.CarId == Id).ToList();
            
        }

        public List<Car> GetCarByBrandId(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCarByColorId(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.FirstOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.CarDescription = car.CarDescription;
            carToUpdate.ModelYear = car.ModelYear;
        }

       
    }
}
