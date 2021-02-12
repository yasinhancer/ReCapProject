using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Abstract;

namespace Business.Abstract
{
    public interface IService<T>
    {
        IDataResult<List<T>> GetAll();
        IResult Add(T entity);
        IResult Update(T entity);
        IResult Delete(T entity);
    }
}
