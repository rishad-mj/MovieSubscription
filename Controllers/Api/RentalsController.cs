using MovieSubscription.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MovieSubscription.Controllers.Api
{
    public class RentalsController : ApiController
    {
        [HttpPost]
        public IHttpActionResult CreateNewRentals(RentalDTo rentalDTo)
        {
            throw new NotImplementedException();
        }
    }
}
