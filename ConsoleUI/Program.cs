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
            ColorAdd();
            BrandAdd();
            ModelAdd();
            CarAdd();
            

        }

        private static void ColorAdd()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Add(new Color { ColorName = "Mavi" });
        }

        private static void BrandAdd()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(new Brand { BrandName = "BMW" });
        }

        private static void RentalCar()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.Add(new Rental { CarId = 1, CustomerId = 1, RentDate = DateTime.Now, ReturnDate = new DateTime(2021, 03, 28) });
            Console.WriteLine(result.Message);
        }

        private static void CarAdd()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.Add(new Car { BrandId = 1, ColorId = 1, ModelId = 1, ModelYear = 2018, DailyPrice = 1000, CarDescription = "Dizel" }).Message;

            Console.WriteLine(result);
        }

        private static void CustomerAdd()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

            var result = customerManager.Add(new Customer { UserId = 1, CompanyName = "ABC Company" }).Message;
            Console.WriteLine(result);
        }

        private static void UserAdd()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            var result = userManager.Add(new User { FirstName = "Ali", LastName = "Kuşdil", Email = "ali.kusdil@gmail.com", Password = "789" }).Message;
            Console.WriteLine(result);
        }

        private static CarManager GetCarDetailsfull()
        {
            CarManager carManager = new CarManager(new EfCarDal());


            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine("Car Model : " + car.ModelName);
                Console.WriteLine("Car Brand : " + car.BrandName);
                Console.WriteLine("Car Color : " + car.ColorName);
                Console.WriteLine("Car Price : " + car.DailyPrice);
                Console.WriteLine("Car Model Year : " + car.ModelYear);
                Console.WriteLine("Car Description : " + car.CarDescription);
            }

            return carManager;
        }

        private static void ModelAdd()
        {
            ModelManager modelManager = new ModelManager(new EfModelDal());

            modelManager.Add(new Model { ModelName = "5.20 i" });

            Console.WriteLine("Added model");
        }
    }
}
