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
            //CarManager carManager = new CarManager(new EfCarDal());

            //foreach (var car in carManager.GetCarDetails())
            //{
            //    Console.WriteLine("Car Brand : " + car.BrandName + "");
            //}


            //ModelAdd();

            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { BrandId = 1, ColorId = 1, DailyPrice = 1000, ModelId=1, CarDescription="Benzinli", ModelYear=2020});
            Console.WriteLine("Car added");
        }

        private static void ModelAdd()
        {
            ModelManager modelManager = new ModelManager(new EfModelDal());

            modelManager.Add(new Model { ModelName = "5.20 i" });

            Console.WriteLine("Added model");
        }
    }
}
