using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            BrandManager brandManager = new BrandManager(new InMemoryBrandDal());
            ColorManager colorManager = new ColorManager(new InMemoryColorDal());

            foreach (var car in carManager.GetAll())
            {
                foreach (var brand in brandManager.GetAll())
                {
                    foreach (var color in colorManager.GetAll())
                    {
                        if ((car.BrandId == brand.BrandId) && (color.ColorId==car.ColorId))
                        {
                            Console.WriteLine("Car Brand :" + brand.BrandName);
                            Console.WriteLine("Car Color :" + color.ColorName);
                            Console.WriteLine("Car DailyPrice :" + car.DailyPrice);
                            Console.WriteLine("Car Mode Year :" + car.ModelYear);
                            Console.WriteLine("Car Description :" + car.Description);
                        }
                    }
                    
                }
                
            }

        }
    }
}
