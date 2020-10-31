using MovieSubscription.Models;
using MovieSubscription.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieSubscription.Controllers
{
   
    public class CustomersController : BaseController
    {
        // GET: Customers

        private MockDbContext _mockDbcontext = new MockDbContext();


        public ActionResult TestNew()
        {
            return View();
        }
       public ViewResult Index()
        {
            //var memShiptypes = _mockDbcontext.MembershipTypes;
            return View();
        }

        public ActionResult New()
        {
            //MockDbContext mockDbContext = new MockDbContext();
            var viewModel = new CustomerViewModel
            {
                Customer = new Customer(),
                MembershipTypes = _mockDbcontext.GetMembershipTypes()
            };
            return View("CustomerForm",viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Customer customer)
        {

            if (!ModelState.IsValid)
            {
                var viewModel = new CustomerViewModel
                {
                    Customer = customer,
                    MembershipTypes = _mockDbcontext.GetMembershipTypes()
                };
                return View("CustomerForm", viewModel);
            }

            if (customer.Id == 0)
                _mockDbcontext.Customers.Add(customer);
            else
            {
                var customerinDB = _mockDbcontext.Customers.Single(c => c.Id == customer.Id);

                ////this will update ***ALL property** of the customerinDB with the customer object using the Keyvalue pair in the Request data.
                ///so this approach is not that secure even if user updates only one property this method will update all the other properties
                //TryUpdateModel(customerinDB);

                customerinDB.Name = customer.Name;
                customerinDB.Birthdate = customer.Birthdate;
                customerinDB.MembershipTypeId = customer.MembershipTypeId;
                customerinDB.IsSubscribedToNewsletter = customer.IsSubscribedToNewsletter;
                _mockDbcontext.Customers.Add(customer);
            }


            return RedirectToAction("Index", "Customers");
        }

        public ActionResult Edit(int Id)
        {
            var customer = _mockDbcontext.Customers.SingleOrDefault(c => c.Id == Id);

            if (customer == null)
                return HttpNotFound();

            var viewModel = new CustomerViewModel
            {
                Customer = customer,
                MembershipTypes = _mockDbcontext.GetMembershipTypes()
            };

            return View("CustomerForm", viewModel);
        }

        public ActionResult Details(int ID)
        {
            Customer cust = GetCustomers().CustomerList.Find(c => c.Id == ID);
            return View(cust);
        }
        private Customers GetCustomers()
        {
            Customers CustomerList = new Customers();
            var customers = new List<Customer>
            {
                new Customer{Id=1, Name="John Smith"},
                new Customer{Id=2, Name="Marry Williams"}
            };
            CustomerList.CustomerList = customers;
            return CustomerList;

        }
    }
}