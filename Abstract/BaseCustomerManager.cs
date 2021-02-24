using CoffeeShopDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopDemo.Abstract
{
    public abstract class BaseCustomerManager : ICustomerServices
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " Saved DB ");
        }
    }
}
