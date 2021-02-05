using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
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

            string secimAlani = " 1- Add New Car\n 2- Add New Brand \n 3- Add New Color\n " +
                "4- GetByColorId\n 5- GetByBrandId \n 6- GetByDailyPrice \n 7- GetByModelYears \n 8- GetAllCars";
            Console.WriteLine(secimAlani);

            foreach (var car in carManager.GetCarsByBrandId(1))
            {
                Console.WriteLine("{0} marka id'li {1} tanımlı araç", car.BrandId, car.Description);
            }

            foreach (var car in carManager.GetCarsByColorId(3))
            {
                Console.WriteLine("{0} rank id'li araç, günlük {1} TL'ye kiralanır.",car.ColorId,car.DailyPrice);
            }

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("{0} model aracımız, günlük {1}Tl'ye kiralanır. {2}",car.ModelYear,car.DailyPrice,car.Description);
            }

        }
    }
}
