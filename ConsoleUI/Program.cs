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
            ColorManager colorManager = new ColorManager(new EfColorDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            string karsılama = "\nAraç kiralama sistemine hoşgeldiniz.\n";
            Console.WriteLine(karsılama);

            //string secimAlani = " 1- Add New Car\n 2- Add New Brand \n 3- Add New Color\n " +
            //    "4- GetByColorId\n 5- GetByBrandId \n 6- GetByDailyPrice \n 7- GetByModelYears \n 8- GetAllCars";
            //Console.WriteLine(secimAlani);

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Id:{0} / Year:{1} / {2}TL / Description:{3}",car.Id,car.ModelYear,car.DailyPrice,car.Description);
            }

            //foreach (var car in carManager.GetCarsByBrandId(1))
            //{
            //    Console.WriteLine("{0} marka id'li {1} tanımlı araç", car.BrandId, car.Description);
            //}

            //foreach (var car in carManager.GetCarsByColorId(3))
            //{
            //    Console.WriteLine("{0} rank id'li araç, günlük {1} TL'ye kiralanır.", car.ColorId, car.DailyPrice);
            //}

            //carManager.Add(new Car{BrandId=5, ColorId=1, ModelYear=2015, DailyPrice=1430, Description="Uygun fiyata..." });
            // carManager.Update(new Car{ Id=1002,BrandId = 4, ColorId = 3, ModelYear = 2017, DailyPrice = 1450, Description = "Uygun fiyata..." });
            // carManager.Delete(new Car { Id=1002});


        }
    }
}
