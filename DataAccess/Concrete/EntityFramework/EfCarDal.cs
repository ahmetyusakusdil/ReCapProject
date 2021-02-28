using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            using (ReCarContext context = new ReCarContext())
            {
               
                var addedCar = context.Entry(entity);
                addedCar.State = EntityState.Added;
                context.SaveChanges();
                           
          
            }
        }

       

        public void Delete(Car entity)
        {
            using (ReCarContext context = new ReCarContext())
            {
                var deletedCar = context.Entry(entity);
                deletedCar.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (ReCarContext context = new ReCarContext())
            {
                return context.Set<Car>().SingleOrDefault(filter);
            }
        }

     

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (ReCarContext context = new ReCarContext())
            {
                return filter == null ? context.Set<Car>().ToList() : context.Set<Car>().Where(filter).ToList();
            }
        }

        public List<Car> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCarByBrandId(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCarByColorId(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

       

        public void Update(Car entity)
        {
            throw new NotImplementedException();
        }

    }
}
