using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Abstract;
using Core.Utilities.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities;
using Entities.DTOs;

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
        public IResult Add(Car car)
        {
            using (DatabaseContext databaseContext = new DatabaseContext())
            {
                bool result = databaseContext.Cars.Contains(car);
                if (result != true && car.Description.Length >= 2 && car.DailyPrice > 0)
                {
                    _carDal.Add(car);
                    Console.WriteLine("{0} {1}", car.Description,Messages.Added);
                    return new SuccessResult();
                }
                else
                {
                    Console.WriteLine("{0} {1}", car.Description, Messages.SameEntry);
                    return new ErrorResult();
                }
            }
        }

        public IResult Update(Car car)
        {
            using (DatabaseContext databaseContext = new DatabaseContext())
            {
                bool result = databaseContext.Cars.Contains(car);
                if (result == true)
                {
                    _carDal.Update(car);
                    Console.WriteLine("{0} {1}", car.Description, Messages.Updated);
                    return new SuccessResult();
                }
                else
                {
                    Console.WriteLine("{0} {1}", car.Description, Messages.InvalidData);
                    return new ErrorResult();
                }
            }

        }
        public IResult Delete(Car car)
        {
            using (DatabaseContext databaseContext = new DatabaseContext())
            {
                bool result = databaseContext.Cars.Contains(car);
                if (result == true)
                {
                    _carDal.Delete(car);
                    Console.WriteLine("{0} {1}",car.Description, Messages.Deleted);
                    return new SuccessResult();
                }
                else
                {
                    Console.WriteLine("{0} {1}",car.Description, Messages.InvalidData);
                    return new ErrorResult();
                }
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

        public List<CarDetailDto> GetCarDetails()
        {
            return new List<CarDetailDto>(_carDal.GetCarDetails());
        }

        IDataResult<List<Car>> IService<Car>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}