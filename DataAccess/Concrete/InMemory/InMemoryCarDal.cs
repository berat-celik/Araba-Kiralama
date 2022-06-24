using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car{CarId=1,BrandId=2,ColorId=2,DailyPrice=450,ModelYear=2011,Description="Araba-1"},
                new Car{CarId=2,BrandId=1,ColorId=5,DailyPrice=350,ModelYear=2012,Description="Araba-2"},
                new Car{CarId=3,BrandId=4,ColorId=3,DailyPrice=460,ModelYear=2015,Description="Araba-3"},
                new Car{CarId=4,BrandId=3,ColorId=1,DailyPrice=750,ModelYear=2010,Description="Araba-4"},
                new Car{CarId=5,BrandId=5,ColorId=4,DailyPrice=240,ModelYear=2019,Description="Araba-5"},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car) 
        {
            Car carToDelete = _cars.SingleOrDefault(c=> c.CarId == car.CarId);

            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c=> c.CarId == carId).ToList();

        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c=> c.CarId == car.CarId);

            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
