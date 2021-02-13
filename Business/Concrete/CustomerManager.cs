using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public IDataResult<List<Customer>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IResult Add(Customer customer)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                bool result = context.Customers.Contains(customer);
                if (result != true && customer.CompanyName.Length >= 3 || customer.CompanyName.Length >= 3)
                {
                    _customerDal.Add(customer);
                    Console.WriteLine("{0}", Messages.Added);
                    return new SuccessResult();
                }
                else
                {
                    Console.WriteLine("{0}", Messages.InvalidEntry);
                    return new ErrorResult();
                }
            }
        }

        public IResult Update(Customer customer)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                bool result = context.Customers.Contains(customer);
                if (result == true && customer.CompanyName.Length >= 3)
                {
                    _customerDal.Update(customer);
                    Console.WriteLine("{0} {1}", customer.CompanyName, Messages.Updated);
                    return new SuccessResult();
                }
                else
                {
                    Console.WriteLine("{0}", Messages.InvalidEntry);
                    return new ErrorResult();
                }
            }
        }

        public IResult Delete(Customer customer)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                bool result = context.Customers.Contains(customer);
                if (result == true )
                {
                    _customerDal.Delete(customer);
                    Console.WriteLine("{0} {1}", customer.CompanyName, Messages.Deleted);
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
