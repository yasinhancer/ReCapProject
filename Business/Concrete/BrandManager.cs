using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
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
    public class BrandManager : IBrandService 
    {  
        //DEPENDENCY INJECTION
        IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        IDataResult<List<Brand>> IService<Brand>.GetAll()
        {
            throw new NotImplementedException();
        }

        IResult IService<Brand>.Add(Brand brand)
        {
            using (DatabaseContext databaseContext = new DatabaseContext())
            {
                bool result = databaseContext.Brands.Contains(brand);
                if (result != true && brand.Name.Length >=3 )
                {
                    _brandDal.Add(brand);
                    Console.WriteLine("{0} {1}", brand.Name,Messages.Added);
                    return new SuccessResult();
                }
                else
                {
                    Console.WriteLine("{0}",Messages.InvalidEntry);
                    return new ErrorResult();
                }
                
            }
        }

        IResult IService<Brand>.Update(Brand brand)
        {
            using (DatabaseContext databaseContext = new DatabaseContext())
            {
                bool result = databaseContext.Brands.Contains(brand);
                if (result == true && brand.Name.Length >= 3)
                {
                    _brandDal.Update(brand);
                    Console.WriteLine("{0} {1}", brand.Name, Messages.Updated);
                    return new SuccessResult();
                }
                else
                {
                    Console.WriteLine("{0}", Messages.InvalidEntry);
                    return new ErrorResult();
                }

            }
        }

        IResult IService<Brand>.Delete(Brand brand)
        {
            using (DatabaseContext databaseContext = new DatabaseContext())
            {
                bool result = databaseContext.Brands.Contains(brand);
                if (result == true)
                {
                    _brandDal.Delete(brand);
                    Console.WriteLine("{0} {1}", brand.Name, Messages.Deleted);
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
