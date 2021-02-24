using CoffeeShopDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopDemo.Abstract
{
    public interface ICustomerCheckServices
    {
        bool CheckIfRealPersonAsync(Customer customer);
    }
}
