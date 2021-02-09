using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore.Internal;

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
        
        DatabaseContext databaseContext = new DatabaseContext();
        
        public void Add(Brand brand)
        {
            bool result = databaseContext.Brands.Contains(brand);
            if (result != true)
            {
                _brandDal.Add(brand); 
                Console.WriteLine(brand.Name + " markası sisteme eklendi.");
            }
            else
            {
                Console.WriteLine(brand.Name + " markası zaten sistemde mevcut!");
            }        
        }
        
        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public void Update(Brand brand)
        {
            _brandDal.Update(brand);
        }

        public void Delete(Brand brand)
        {
            bool result = databaseContext.Brands.Contains(brand);
            if (result == true)
            {
                _brandDal.Delete(brand);
                Console.WriteLine(brand.Name + " markası sistemden silindi.");
            }
            else
            {
                Console.WriteLine(brand.Name + " markası zaten sistemde mevcut değil!");
            }
            
        }
    }
}
