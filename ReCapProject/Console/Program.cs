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
            //CarDetailDtoTest();
            CarTest();
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
            var result = colorManager.GetById(2);
            System.Console.WriteLine(result.Data.ColorName);
            System.Console.WriteLine("\n");


            System.Console.WriteLine("-------GetAll()-------");
            var result1 = colorManager.GetAll();
            if(result1.Success==true)
            {
                foreach (var c in result1.Data)
                {
                    System.Console.WriteLine(c.ColorName + " renkli araç");
                }
            }
            else
            {
                System.Console.WriteLine(result1.Message);
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
            var result = brandManager.GetById(2);
            System.Console.WriteLine(result.Data.BrandName);
            System.Console.WriteLine("\n");

            System.Console.WriteLine("-------GetAll()-------");
            var result1 = brandManager.GetAll();
            if(result1.Success == true)
            {
                foreach (var b in result1.Data)
                {
                    System.Console.WriteLine(b.BrandName + " markalı araç");
                }
            }
            else
            {
                System.Console.WriteLine(result.Message);
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
            var result = carManager.GetCarsByBrandId(2);
            if (result.Success == true)
            {
                foreach (var c in result.Data)
                {
                    System.Console.WriteLine(c.Descriptions);
                }
            }
            else
            {
                System.Console.WriteLine(result.Message);
            }
            System.Console.WriteLine("\n");

            System.Console.WriteLine("-------GetCarsByColorId()-------");
            var result1 = carManager.GetCarsByColorId(4);
            if(result1.Success==true)
            {
                foreach (var c in result1.Data)
                {
                    System.Console.WriteLine(c.ModelYear);
                }
            }
            else
            {
                System.Console.WriteLine(result1.Message);
            }
            System.Console.WriteLine("\n");

            System.Console.WriteLine("-------GetById()-------");
            var result2 = carManager.GetById(2);
            System.Console.WriteLine(result2.Data.Descriptions);
            System.Console.WriteLine("\n");

            System.Console.WriteLine("-------GetAll()-------");
            var result3 = carManager.GetAll();
            if(result3.Success==true)
            {
                foreach (var c in result3.Data)
                {
                    System.Console.WriteLine(c.BrandId + " " + "markalı araç" + " " + c.ColorId + " " + "renginde" + " "
                                             + c.ModelYear + " " + "modelinde" + " " + c.DailyPrice + " " + "fiyata sahip" + " " + c.Descriptions + "tır.");
                }
            }
            else
            {
                System.Console.WriteLine(result3.Message);
            }
            
        }

        private static void CarDetailDtoTest()
        {
            System.Console.WriteLine("\n--------CAR DETAIL-------");
            CarManager carmanager = new CarManager(new EfCarDal());
            var result = carmanager.GetCarDetails();
            if(result.Success==true)
            {
                foreach (var car in result.Data)
                {
                    System.Console.WriteLine("Car Name : " + car.CarName + "\n" +
                                            "Brand Name : " + car.BrandName + "\n" +
                                            "Color Name : " + car.ColorName + "\n" +
                                            "Daily Price : " + car.DailyPrice + "\n");
                }
            }
            else
            {
                System.Console.WriteLine(result.Message);
            }

            System.Console.WriteLine("Şu kadar araç listelendi : " + result.Data.Count);

        }

    }
}
