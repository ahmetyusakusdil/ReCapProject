using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
   public interface ICarService
    {
        List<Car> GetAll();

        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);
        Car Get(int Id);
        List<CarDetailDto> GetCarDetails();
        List<Car> GetCarsByBrandId(int id);
        List<Car> GetCarsByColorId(int id);
        




    }
}
