using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryDal()
        {

            _cars = new List<Car> { 
                new Car {Id=1,BrandId="Toyota",ColorId="Kırmızı",DailyPrice=80000,Description="Babam gibi araba",ModelYear=2006},
                new Car {Id=1,BrandId="Hyundai",ColorId="Beyaz",DailyPrice=65000,Description="Bir Japon teknolojisi",ModelYear=2005},
                new Car {Id=1,BrandId="Subaru",ColorId="Mavi",DailyPrice=110000,Description="Rallylerin efendisi",ModelYear=2010},
                new Car {Id=1,BrandId="Ferrari",ColorId="Sarı",DailyPrice=180000,Description="Şahlanan at",ModelYear=2011},
                new Car {Id=1,BrandId="Mercedes",ColorId="Metalik Gri",DailyPrice=175000,Description="Gümüş oklar",ModelYear=2010}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            var carDelete = _cars.SingleOrDefault(p=>p.Id==car.Id);
            _cars.Remove(carDelete);

        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetByID(string carId)
        {
            return _cars.Where(p => p.BrandId == carId).ToList();
        }

        public void Update(Car car)
        {
            var carUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
            carUpdate.BrandId = car.BrandId;
            carUpdate.ColorId = car.ColorId;
            carUpdate.DailyPrice = car.DailyPrice;
            carUpdate.Description = car.Description;
            carUpdate.ModelYear = car.ModelYear;

        }
    }
}
