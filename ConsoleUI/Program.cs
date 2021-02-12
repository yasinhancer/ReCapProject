using System;
using Business.Concrete;
using Business.Constants;
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
            colorManager.Add(maviColor);


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
                Description = "BMW E60 M5",
                ModelYear = 2008
            };
            //carManager.Add(car1);
            //UpdateTest(car1, carManager);
            Car car2 = new Car()
            {
                Id = 2,
                BrandId = 4,
                ColorId = 1,
                DailyPrice = 299,
                Description = "Volkswagen Passat / Otomatik",
                ModelYear = 2015
            };
            //carManager.Add(car2);
            Car car3 = new Car()
            {
                Id = 3, 
                BrandId = 5,
                ColorId = 5,
                DailyPrice = 249,
                Description = "Seat Leon / Otomatik",
                ModelYear = 2008
            };
            //carManager.Add(car3);
            Car car4 = new Car()
            {
                Id = 4,
                BrandId = 3,
                ColorId = 2, 
                DailyPrice = 699,
                Description = "Audi A6 / Otomatik",
                ModelYear = 2019
            };
            
            Car car5 = new Car()
            {
                Id = 5,
                BrandId = 3,
                ColorId = 3,
                DailyPrice = 449,
                Description = "Audi A5 / Otomatik",
                ModelYear = 2018
            }; 
            //carManager.Delete(car5);
            //****************************************************************************************************************

            //GetAllTest(carManager);
            //GetCarDetailsTest(carManager);
            


        }

        private static void GetCarDetailsTest(CarManager carManager)
        {
            foreach (var carDetail in carManager.GetCarDetails())
            {
                Console.WriteLine("Araç: {0} | Marka: {1} | Renk: {2} | Günlük Kiralama Bedeli {3}TL \n ", carDetail.CarName,
                    carDetail.BrandName,
                    carDetail.ColorName, carDetail.DailyPrice);
            }
        }

        private static void UpdateTest(Car car1, CarManager carManager)
        {
            car1.Description = "BMW E60 M5 / Otomatik";
            carManager.Update(car1);
        }

        private static void GetAllTest(CarManager carManager)
        {
            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine(item.Id + " -> " + item.Description);
            }
        }
        
    }
}
