using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieSubscription.Models
{
    public class MockDbContext
    {


        private List<Customer> _custList = new List<Customer>();
        public List<Customer> Customers
        {
            get
            {
                _custList = GetCustomers();
                return _custList;
            }
            set { _custList = value; }
        }
        public List<Movie> Movies { get; set; }

        private List<MembershipType> _memTypes = new List<MembershipType>();
        public List<MembershipType> MembershipTypes
        {
            get
            {
                _memTypes = GetMembershipTypes();
                return _memTypes;
            }
            set { _memTypes = value; }
        }
        public List<Genre> Genres { get; set; }
        public List<Rental> Rentals { get; set; }

        public List<Customer> GetCustomers()
        {
            var customers = new List<Customer>
            {
                new Customer{Id=1, Name="John Smith", IsSubscribedToNewsletter=true, Birthdate=DateTime.Now, MembershipTypeId=MembershipType.PayAsYouGo},
                new Customer{Id=2, Name="Marry Williams",IsSubscribedToNewsletter=false, Birthdate=DateTime.Now, MembershipTypeId=MembershipType.Unknown},
                new Customer{Id=3, Name="Amy Williams",IsSubscribedToNewsletter=false, Birthdate=DateTime.Now, MembershipTypeId=MembershipType.Unknown}
            };

            return customers;

        }

        public List<MembershipType> GetMembershipTypes()
        {
            var membershipTypes = new List<MembershipType>
            {
                new MembershipType{Id=1, Name="Pay As you go" ,DiscountRate= 0,DurationInMonths=0,SignUpFee=20 },
                new MembershipType{Id=2, Name="Monthly" ,DiscountRate= 2,DurationInMonths=1,SignUpFee=16 },
                new MembershipType{Id=3, Name="Quaterly" ,DiscountRate= 3,DurationInMonths=3,SignUpFee=10 },
                new MembershipType{Id=4, Name="Half Yearly" ,DiscountRate= 6,DurationInMonths=6,SignUpFee=5 },
                new MembershipType{Id=5, Name="Annual" ,DiscountRate= 10,DurationInMonths=12,SignUpFee=0 },

            };

            return membershipTypes;
        }

    }
}