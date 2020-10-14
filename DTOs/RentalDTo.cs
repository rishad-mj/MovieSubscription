using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieSubscription.DTOs
{
    public class RentalDTo
    {
        public int CustomerId { get; set; }
        public List<int> MovieIds { get; set; }
    }
}