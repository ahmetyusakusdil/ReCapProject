using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCarContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (ReCarContext context = new ReCarContext())
            {
                var result = from r in context.Rentals
                             join c in context.Cars on r.CarId equals c.CarId
                             join cs in context.Customers on r.CustomerId equals cs.CustomerId
                             join u in context.Users on r.UserId equals u.UserId
                             join b in context.Brands on r.BrandId equals b.BrandId


                             select new RentalDetailDto
                             {
                                 BrandName = b.BrandName,
                                 RentId = r.RentId,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate


                             };
                return result.ToList();

            }
        }
    }
}
