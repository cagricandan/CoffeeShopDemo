using CoffeeShopDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopDemo.Abstract
{
    public interface ICustomerServices
    {
        void Save(Customer customer);
    }
}
