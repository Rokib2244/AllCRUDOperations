using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EO = TicketBookingSystem.Training.Entities;
using BO = TicketBookingSystem.Training.BussinessObjects;

namespace TicketBookingSystem.Training.Profiles
{
    public class TrainingProfile : Profile
    {
        public TrainingProfile()
        {
            CreateMap<EO.Customer, BO.Customer>().ReverseMap();
        }
    }
}
