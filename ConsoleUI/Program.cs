using System;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
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
            //randManager.Add(seatBrand);

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
            colorManager.Add(sarıColor);

            //carManager.Add(new Car()
            //{
            //    Id = 1,
            //    BrandId = 1,
            //    ColorId = 2,
            //    DailyPrice = 1500,
            //    Description = "BMW E60 M5",
            //    ModelYear = 2008
            //});
            Console.ReadLine();
        }
    }
}
