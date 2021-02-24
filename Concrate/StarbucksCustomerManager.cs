using CoffeeShopDemo.Abstract;
using CoffeeShopDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopDemo.Concrate
{
    public class StarbucksCustomerManager:BaseCustomerManager
    {
        private ICustomerCheckServices _customerCheckServices;
        public StarbucksCustomerManager(ICustomerCheckServices customerCheckServices)
        {
            _customerCheckServices = customerCheckServices;
        }

        public override void Save(Customer customer)
        {
            if (_customerCheckServices.CheckIfRealPersonAsync(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("not a real person");
            }
            
        }


    }
}
