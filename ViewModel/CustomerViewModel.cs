﻿using MovieSubscription.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieSubscription.ViewModel
{
    public class CustomerViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}