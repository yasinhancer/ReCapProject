using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Abstract;
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
        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }
        public void Add(Color color)
        {
            using (DatabaseContext databaseContext = new DatabaseContext())
            {
                bool result = databaseContext.Colors.Contains(color);
                if (result == true)
                {
                    Console.WriteLine(color.Name + " renk zaten sistemde mevcut!");
                }
                else
                {
                    _colorDal.Add(color);
                    Console.WriteLine(color.Name + " renk sisteme eklendi.");
                }
            }
        }
        public void Update(Color color)
        {
            _colorDal.Update(color);
        }
        public void Delete(Color color)
        {
            using (DatabaseContext databaseContext = new DatabaseContext())
            {
                bool result = databaseContext.Colors.Contains(color);
                if (result == true)
                {
                    _colorDal.Delete(color);
                    Console.WriteLine(color.Name + " renk sistemden silindi.");
                }
                else
                {
                    Console.WriteLine(color.Name + " renk zaten sistemde mevcut değil!");
                }
            }
        }
    }
}