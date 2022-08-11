using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketBookingSystem2.Training.BusinessObjects;
using TicketBookingSystem2.Areas.Admin.Models;

namespace TicketBookingSystem2.Profiles
{
    public class WebProfile : Profile
    {
        public WebProfile()
        {
            CreateMap<CreateCustomerModel, Customer>().ReverseMap();
        }
    }
}
