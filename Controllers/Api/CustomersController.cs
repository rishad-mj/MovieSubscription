using AutoMapper;
using MovieSubscription.App_Start;
using MovieSubscription.DTOs;
using MovieSubscription.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MovieSubscription.Controllers.Api
{
    public class CustomersController : ApiController
    {
        private MockDbContext _mockContext;

        public CustomersController()
        {
            _mockContext = new MockDbContext();
        }
        //GET/api/customers
        //public IEnumerable<CustomerDTO> Getcustomers()
        public IHttpActionResult  Getcustomers()
        {
            return Ok(_mockContext.Customers.Select(AutoMapperConfig.Mapper.Map<Customer,CustomerDTO>));
        }

        public IHttpActionResult GetCustomer(int id)
        {
            var customer = _mockContext.Customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return NotFound();

            return Ok(AutoMapperConfig.Mapper.Map<Customer,CustomerDTO>(customer));

        }

        //POST/api/customers
        [HttpPost]
        public IHttpActionResult CreateCustomer(CustomerDTO customerDTO)
        {
            if (ModelState.IsValid)
                return BadRequest();

            var customer = AutoMapperConfig.Mapper.Map<CustomerDTO, Customer>(customerDTO);
            _mockContext.Customers.Add(customer);

            return Created(new Uri (Request.RequestUri+"/" + customer.Id), customerDTO);
        }

        //PUT /api/Customers/1
        [HttpPut]
        public void UpdateCustomer(int id, Customer customer)
        {
            if (ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);


            var customerinDB = _mockContext.Customers.SingleOrDefault(c => c.Id == id);

            if (customerinDB == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            //Code for Update comment

        }

        //Delete /api/customers/1
        [HttpDelete]
        public void Deletecustomers(int id)
        {
            var customerinDB = _mockContext.Customers.SingleOrDefault(c => c.Id == id);
            if (customerinDB == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _mockContext.Customers.Remove(customerinDB);

        }
    }
}
