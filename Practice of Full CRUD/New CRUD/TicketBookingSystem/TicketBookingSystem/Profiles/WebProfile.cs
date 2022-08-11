using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketBookingSystem.Areas.Admin.Models;
using TicketBookingSystem.Training.BussinessObjects;

namespace TicketBookingSystem.Profiles
{
    public class WebProfile : Profile
    {
        public WebProfile()
        {
            CreateMap<Customer, CreateCustomerModel>().ReverseMap();
            CreateMap<Customer, EditCustomerModel>().ReverseMap();
            CreateMap<Customer, DeleteCustomerModel>().ReverseMap();
        }
    }
}
