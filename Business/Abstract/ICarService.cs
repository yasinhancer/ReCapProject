using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Abstract;
using Entities;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface ICarService : IService<Car>
    {
        IDataResult<List<CarDetailDto>> GetCarDetails();
    }
}
