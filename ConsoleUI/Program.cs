using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal(), new EfBrandDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());

          

            //brandManager.Add(new Brand { BrandId=1, BrandName = "BMW" });
            //colorManager.Add(new Color { ColorId= 1, ColorName = "beyaz" });
            carManager.Add(new Car { CarId=5, BrandId=1, ColorId=4, CarDescription="benzin", DailyPrice=650, ModelYear=2021});
            
        }
    }
}
