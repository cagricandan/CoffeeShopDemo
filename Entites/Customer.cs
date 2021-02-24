using CoffeeShopDemo.Abstract;
using System;

namespace CoffeeShopDemo.Entities
{
    public class Customer : Ientity
    {
        public int Id { get; set; }
        public string NationalityId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
