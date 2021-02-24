using CoffeeShopDemo.Abstract;
using CoffeeShopDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopDemo.Concrate
{
    class CustomerCheckManager : ICustomerCheckServices
    {
        public bool CheckIfRealPersonAsync(Customer customer)
        {
            return true;
        }
        
    }
}
