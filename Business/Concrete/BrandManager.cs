using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
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
        public void Add(Brand brand)
        {
            using (DatabaseContext databaseContext = new DatabaseContext()) //using sayesinde, metot bittiği an, referansı dispose edecek (bellekten silme)
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
        }
        

        public void Update(Brand brand)
        {
            _brandDal.Update(brand);
        } 
        public void Delete(Brand brand)
        {
            using (DatabaseContext databaseContext = new DatabaseContext())
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

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }
    }
}
