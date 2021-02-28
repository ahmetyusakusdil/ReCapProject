using Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
   public interface ICarDal : IEntityRepository<Car>
    {
        List<Car> GetCarByBrandId(Expression<Func<Car, bool>> filter);

        List<Car> GetCarByColorId(Expression<Func<Car, bool>> filter);
    }
}
