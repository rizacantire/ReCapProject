using Business.Concrete;
using DataAccess.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager manager = new CarManager(new InMemoryDal());
            var cars = manager.GetAll();
            Console.WriteLine("Arabalar listesi:");
            foreach (var car in cars)
            {
                Console.WriteLine("---------");
                Console.WriteLine("Markası : " + car.BrandId);
                Console.WriteLine("Rengi : " + car.ColorId);
                Console.WriteLine("Fiyatı : " + car.DailyPrice);
                Console.WriteLine("Yılı : " + car.ModelYear);
                Console.WriteLine("Açıklama : " +car.Description);
            }

        }
    }
}
