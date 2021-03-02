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
            
           CarManager carManager = new CarManager(new EfCarDal());


            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine("Car Model : " + car.ModelName);
                Console.WriteLine("Car Brand : " + car.BrandName);
                Console.WriteLine("Car Color : " + car.ColorName);
                Console.WriteLine("Car Price : " + car.DailyPrice);
                Console.WriteLine("Car Model Year : " + car.ModelYear);
                Console.WriteLine("Car Description : " + car.CarDescription);
            }

            carManager.Delete(new Car { CarId = 1 });

            
        }

        private static void ModelAdd()
        {
            ModelManager modelManager = new ModelManager(new EfModelDal());

            modelManager.Add(new Model { ModelName = "5.20 i" });

            Console.WriteLine("Added model");
        }
    }
}
