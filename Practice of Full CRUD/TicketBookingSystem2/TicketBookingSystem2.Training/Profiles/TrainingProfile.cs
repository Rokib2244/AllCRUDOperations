using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EO = TicketBookingSystem2.Training.Entities;
using BO = TicketBookingSystem2.Training.BusinessObjects;

namespace TicketBookingSystem2.Training.Profiles
{
    public class TrainingProfile : Profile
    {
        public TrainingProfile()
        {
            CreateMap<EO.Customer, BO.Customer>().ReverseMap();
        }
    }
}
