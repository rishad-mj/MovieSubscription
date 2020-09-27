using MovieSubscription.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieSubscription.ViewModel
{
    public class RandomViewModel
    {
        public Movie movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}