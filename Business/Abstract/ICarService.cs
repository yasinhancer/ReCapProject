using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface ICarService : IService<Car>
    {
        List<CarDetailDto> GetCarDetails();
    }
}
