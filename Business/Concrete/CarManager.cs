using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        //DEPENDENCY INJECTION
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        DatabaseContext databaseContext = new DatabaseContext();

        public void Add(Car car)
        {
            bool result = databaseContext.Cars.Contains(car);
            if (result == true)
            {
                Console.WriteLine(car.Id + " numaralı araç zaten sistemde mevcut!");
            }
            else
            {
                if (car.Description.Length >= 2 && car.DailyPrice > 0)
                {
                    _carDal.Add(car);
                    Console.WriteLine(car.Id + " numaralı araç sisteme eklendi.");
                }
            }
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }

        public void Delete(Car car)
        {
            bool result = databaseContext.Cars.Contains(car);
            if (result == true)
            {
                _carDal.Delete(car);
                Console.WriteLine(car.Id + " numaralı araç sistemden silindi.");
            }
            else
            {
                Console.WriteLine(car.Id + " numaralı araç zaten sistemde mevcut değil!");
            }
            
        }

        public List<Car> GetCarsByBrandId(int Id)
        {
            return _carDal.GetAll(a=>a.BrandId == Id);
        }

        public List<Car> GetCarsByColorId(int Id)
        {
            return _carDal.GetAll(a => a.ColorId == Id);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }
    }
}
