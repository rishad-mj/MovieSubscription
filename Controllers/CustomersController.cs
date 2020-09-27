using MovieSubscription.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieSubscription.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers

        public ActionResult Index()
        {

            return View(GetCustomers());
        }

        public ActionResult Details(int ID)
        {
            Customer cust = GetCustomers().CustomerList.Find(c => c.ID == ID);
            return View(cust);
        }
        private Customers GetCustomers()
        {
            Customers CustomerList = new Customers();
            var customers = new List<Customer>
            {
                new Customer{ID=1, Name="John Smith"},
                new Customer{ID=2, Name="Marry Williams"}
            };
            CustomerList.CustomerList = customers;
            return CustomerList;

        }
    }
}