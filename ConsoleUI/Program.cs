using System;
using Business.Concrete;
using Business.Constants;
using Core.Utilities.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities;
using Entities.Concrete;

namespace ConsoleUI
{ 
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("RENT A CAR PROJECT");
            Console.WriteLine("");
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal()); 
            
            Brand bmwBrand = new Brand()
            {
                Id = 1,
                Name = "BMW"
            };
            //brandManager.Add(bmwBrand);
            Brand mercedesBrand = new Brand() 
            {
                Id = 2,
                Name = "Mercedes-Benz"
            };
            //brandManager.Add(mercedesBrand);
            
            Brand audiBrand = new Brand()
            {
                Id = 3,
                Name = "Audi"
            };
            //brandManager.Add(audiBrand); 
            
            Brand volkswagenBrand = new Brand()
            {
                Id = 4,
                Name = "Volkswagen"
            };
            //brandManager.Add(volkswagenBrand);

            Brand seatBrand = new Brand()
            {
                Id = 5,
                Name = "Seat"
            };
            //brandManager.Add(seatBrand);

            Brand renaultBrand = new Brand()
            {
                Id = 6,
                Name = "Renault"
            };
            //brandManager.Add(renaultBrand);

            Brand hyundaiBrand = new Brand()
            { 
                Id = 7,
                Name = "Hyundai"
            };
            //brandManager.Add(hyundaiBrand);
            
            //***************************************************************************************************************************************
            
            Color beyazColor = new Color()
            {
                Id = 1,
                Name = "Beyaz"
            };
            //colorManager.Add(beyazColor); 
            
            Color siyahColor = new Color()
            {
                Id = 2,
                Name = "Siyah"
            };
            //colorManager.Add(siyahColor);
            
            Color griColor = new Color()
            {
                Id = 3,
                Name = "Gri"
            };
            //colorManager.Add(griColor);
            
            Color maviColor = new Color()
            {
                Id = 4,
                Name = "Mavi"
            };
            //colorManager.Add(maviColor);


            Color kırmızıColor = new Color()
            {
                Id = 5,
                Name = "Kırmızı"
            };
            //colorManager.Add(kırmızıColor);

            Color sarıColor = new Color()
            {
                Id = 6,
                Name = "Sarı"
            };
            //colorManager.Add(sarıColor);

            Car car1 = new Car()
            {
                Id = 1,
                BrandId = 1,
                ColorId = 2,
                DailyPrice = 1499,
                Description = "E60 M5 / Otomatik Vites",
                ModelYear = 2008
            };
            //carManager.Update(car1);
            //UpdateTest(car1, carManager);
            Car car2 = new Car()
            {
                Id = 2,
                BrandId = 4,
                ColorId = 1,
                DailyPrice = 299,
                Description = "Passat / Otomatik Vites",
                ModelYear = 2015
            };
            //carManager.Update(car2);
            Car car3 = new Car()
            {
                Id = 3, 
                BrandId = 5,
                ColorId = 5,
                DailyPrice = 249,
                Description = "Leon / Otomatik Vites",
                ModelYear = 2008
            };
            //carManager.Update(car3);
            Car car4 = new Car()
            {
                Id = 4,
                BrandId = 3,
                ColorId = 2, 
                DailyPrice = 699,
                Description = "A6 / Otomatik Vites",
                ModelYear = 2019
            };
            //carManager.Update(car4);
            Car car5 = new Car()
            {
                Id = 5,
                BrandId = 3,
                ColorId = 3,
                DailyPrice = 449,
                Description = "A5 / Otomatik Vites",
                ModelYear = 2018
            }; 
            //carManager.Update(car5);
            //****************************************************************************************************************
            
            //GetAllTest(carManager);
            GetCarDetailsTest(carManager);


            Console.ReadLine();
        }

        private static void GetCarDetailsTest(CarManager carManager)
        {
            var result = carManager.GetCarDetails();
            Console.WriteLine("***************************************************** Tüm Araçlarımız *****************************************************\n");
            foreach (var car in result.Data)
            {
                Console.WriteLine("Marka: {0} | Model: {1} | Renk: {2} | Günlük Kiralama Bedeli {3}TL \n ", car.BrandName,
                    car.CarName,
                    car.ColorName, car.DailyPrice);
            }
        }

        private static void UpdateTest(Car car1, CarManager carManager)
        {
            car1.Description = "BMW E60 M5 / Otomatik";
            carManager.Update(car1);
        }

        private static void GetAllTest(CarManager carManager)
        {
            var result = carManager.GetAll();
            foreach (var item in result.Data)
            {
                Console.WriteLine(item.Id + " -> " + item.Description);
            }
        }
        
    }
}
