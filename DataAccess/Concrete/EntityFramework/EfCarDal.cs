﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
 
namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car,DatabaseContext>, ICarDal   
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                var result = from car in context.Cars
                    join color in context.Colors
                        on car.ColorId equals color.Id
                    join brand in context.Brands
                        on car.BrandId equals brand.Id
                    select new CarDetailDto()
                    {
                        BrandName = brand.Name, CarName = car.Description,
                        ColorName = color.Name, DailyPrice = car.DailyPrice
                    }; 
                return result.ToList();
            }
        }
    }
}
 