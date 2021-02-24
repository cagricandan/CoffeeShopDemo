using CoffeeShopDemo.Abstract;
using CoffeeShopDemo.Adapters;
using CoffeeShopDemo.Concrate;
using System;

namespace CoffeeShopDemo
{
    partial class Program
    {
        static void Main(string[] args)
        {

            BaseCustomerManager baseCustomerManager = new StarbucksCustomerManager(new CustomerCheckManager());

            baseCustomerManager.Save(new Entities.Customer {Id=1,FirstName="firstname",DateOfBirth = new DateTime(2000,1,11),LastName="lastname",NationalityId="123123123"});


        }
    }
}
