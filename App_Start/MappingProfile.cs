using AutoMapper;
using MovieSubscription.DTOs;
using MovieSubscription.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieSubscription.App_Start
{
    public class MappingProfile: Profile
    {
        protected override void Configure()
        {
            CreateMap<Customer, CustomerDTO>();
            CreateMap<CustomerDTO, Customer>();
            CreateMap<MembershipType, MembershipTypeDto>();

            //CreateMap<CustomerDTO, Customer>().ForMember(c => c.Id, opt => opt.Ignore());
        }
    }
}