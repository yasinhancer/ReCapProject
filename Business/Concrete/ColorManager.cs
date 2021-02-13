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
using Entities.Concrete;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll());
        }

        public IResult Add(Color color)
        {
            using (DatabaseContext databaseContext = new DatabaseContext())
            {
                bool result = databaseContext.Colors.Contains(color);
                if (result != true && color.Name.Length >= 3)
                {
                    _colorDal.Add(color);
                    Console.WriteLine("{0} {1}", color.Name, Messages.Added);
                    return new SuccessResult();
                }
                else
                {
                    Console.WriteLine("{0}", Messages.InvalidEntry);
                    return new ErrorResult();
                }
            }
        }

        public IResult Update(Color color)
        {
            using (DatabaseContext databaseContext = new DatabaseContext())
            {
                bool result = databaseContext.Colors.Contains(color);
                if (result == true && color.Name.Length >= 3)
                {
                    _colorDal.Update(color);
                    Console.WriteLine("{0} {1}", color.Name, Messages.Updated);
                    return new SuccessResult();
                }
                else
                {
                    Console.WriteLine("{0}", Messages.InvalidEntry);
                    return new ErrorResult();
                }
            }
        }

        public IResult Delete(Color color)
        {
            using (DatabaseContext databaseContext = new DatabaseContext())
            {
                bool result = databaseContext.Colors.Contains(color);
                if (result == true)
                {
                    _colorDal.Delete(color);
                    Console.WriteLine("{0} {1}", color.Name, Messages.Deleted);
                    return new SuccessResult();
                }
                else
                {
                    Console.WriteLine("{0}", Messages.InvalidEntry);
                    return new ErrorResult();
                }
            }
        }
    }
}