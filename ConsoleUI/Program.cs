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

            //var result = carManager.GetCarDetails();

            //if (result.Success)
            //{
            //    foreach (var car in result.Data)
            //    {
            //        Console.WriteLine("Arabanın Id'si: " + car.CarId);
            //        Console.WriteLine("Arabanın Markası: " + car.BrandName);
            //        Console.WriteLine("Arabanın Rengi: " + car.ColorName);
            //        Console.WriteLine("Arabanın Günlük Fiyatı: " + car.DailyPrice);
            //        Console.WriteLine("Arabanın Açıklaması: " + car.Description);
            //        Console.WriteLine("Arabanın Model Yılı: " + car.ModelYear);
            //        Console.WriteLine("***********************************");
            //    }

            //}

            RentalManager rentalManager = new RentalManager(new EfRentalDal());
           var result = rentalManager.GetAll();
            if (result.Success)
            {
                foreach (var rental in result.Data)
                {
                    Console.WriteLine(rental.RentalId);
                    Console.WriteLine(rental.CarId);
                    Console.WriteLine(rental.CustomerId);
                    Console.WriteLine(rental.RentDate);
                    Console.WriteLine(rental.ReturnDate);
                }
            }
         

        }
    }
}
