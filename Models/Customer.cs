using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieSubscription.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
    public class Customers
    {
        public List<Customer> CustomerList { get; set; }
    }
}