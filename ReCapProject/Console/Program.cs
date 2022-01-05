using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            CarDetailDtoTest();
            //CarTest();
            //BrandTest();
            //ColorTest();

        }

        private static void ColorTest()
        {
            System.Console.WriteLine("\n--------COLOR-------");
            ColorManager colorManager = new ColorManager(new EfColorDal());

            colorManager.Add(new Color { ColorName = "Sarı" });
            colorManager.Add(new Color { ColorName = "Yeşil" });
            colorManager.Add(new Color { ColorName = "Mor" });
            System.Console.WriteLine("\n");

            System.Console.WriteLine("-------GetById()-------");
            foreach (var co in colorManager.GetById(3))
            {
                System.Console.WriteLine(co.ColorId);
            }
            System.Console.WriteLine("\n");

            System.Console.WriteLine("-------GetAll()-------");
            foreach (var b in colorManager.GetAll())
            {
                System.Console.WriteLine(b.ColorName);
            }
        }

        private static void BrandTest()
        {
            System.Console.WriteLine("\n--------BRAND-------");
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            brandManager.Add(new Brand { BrandName = "BMW" });
            brandManager.Add(new Brand { BrandName = "Ford" });
            brandManager.Add(new Brand { BrandName = "Mini Cooper" });
            System.Console.WriteLine("\n");

            System.Console.WriteLine("-------GetById()-------");
            foreach (var b in brandManager.GetById(3))
            {
                System.Console.WriteLine(b.BrandId);
            }
            System.Console.WriteLine("\n");

            System.Console.WriteLine("-------GetAll()-------");
            foreach (var b in brandManager.GetAll())
            {
                System.Console.WriteLine(b.BrandName);
            }
        }

        private static void CarTest()
        {
            System.Console.WriteLine("\n--------CAR-------");
            CarManager carManager = new CarManager(new EfCarDal());

            carManager.Add(new Car { BrandId = 1, ColorId = 3, ModelYear = "2014", DailyPrice = 100000, Descriptions = "Spor Araç" });
            carManager.Add(new Car { BrandId = 4, ColorId = 2, ModelYear = "2003", DailyPrice = 80000, Descriptions = "Klimalı Araç" });
            carManager.Add(new Car { BrandId = 3, ColorId = 4, ModelYear = "1998", DailyPrice = 50000, Descriptions = "İkinci El Araç" });
            System.Console.WriteLine("\n");


            System.Console.WriteLine("-------GetCarsByBrandId()-------");
            foreach (var c in carManager.GetCarsByBrandId(2))
            {
                System.Console.WriteLine(c.Descriptions);
            }
            System.Console.WriteLine("\n");

            System.Console.WriteLine("-------GetCarsByColorId()-------");
            foreach (var c in carManager.GetCarsByColorId(4))
            {
                System.Console.WriteLine(c.ModelYear);
            }
            System.Console.WriteLine("\n");

            System.Console.WriteLine("-------GetAll()-------");
            foreach (var c in carManager.GetAll())
            {
                System.Console.WriteLine(c.BrandId + " " + "markalı araç" + " " + c.ColorId + " " + "renginde" + " "
                                         + c.ModelYear + " " + "modelinde" + " " + c.DailyPrice + " " + "fiyata sahip" + " "
                                         + c.Descriptions + "tır.");
            }
        }

        private static void CarDetailDtoTest()
        {
            System.Console.WriteLine("\n--------CAR DETAIL-------");
            CarManager carmanager = new CarManager(new EfCarDal());
            foreach (var car in carmanager.GetCarDetails())
            {
                System.Console.WriteLine("Car Name : " + car.CarName + "\n" +
                                        "Brand Name : " + car.BrandName + "\n" +
                                        "Color Name : " + car.ColorName + "\n" +
                                        "Daily Price : " + car.DailyPrice + "\n");
                System.Console.WriteLine("Şu kadar araç listelendi : {carmanager.GetCarDetails().Count}");
            }
        }

    }
}
