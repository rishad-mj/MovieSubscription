using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieSubscription.App_Start
{
    public class AutoMapperConfig
    {
        public static IMapper Mapper;

        public static void ConfigureAutoMapper()
        {
            var config = new MapperConfiguration(cg => cg.AddProfile(new MappingProfile()));

            Mapper = config.CreateMapper();
            //config.AssertConfigurationIsValid();
        }
    }
}