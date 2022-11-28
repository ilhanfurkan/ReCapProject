using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.Description);
            //}

            foreach (var car in carManager.GetCarByColorId(8))
            {
                Console.WriteLine(car.DailyPrice + "$ -- " + car.Description);
            }
            Car car1 = new Car();
            car1.BrandId = 3;
            car1.ColorId = 2;
            car1.ModelYear = 2017;
            car1.DailyPrice = 60;
            car1.Description = "x3 Series";
            //EfCarDal efCarDal = new EfCarDal();
            //efCarDal.Add(car1);

        }

    }
}