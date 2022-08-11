using Autofac;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketBookingSystem2.Training.BusinessObjects;
using TicketBookingSystem2.Training.Services;

namespace TicketBookingSystem2.Areas.Admin.Models
{
    public class CreateCustomerModel
    {
       
        public string Name { get; set; }
        public double ContactNumber { get; set; }
        public double Age { get; set; }
        public string Address { get; set; }
        private readonly ICustomerService _customerService;
        private readonly IMapper _mapper;
        public CreateCustomerModel()
        {
            _customerService = Startup.AutofacContainer.Resolve<ICustomerService>();
            _mapper = Startup.AutofacContainer.Resolve<IMapper>();
        }

        internal void CreateCustomer()
        {
            var customer = _mapper.Map<Customer>(this);
            _customerService.CreateCustomer(customer);
        }
    }
}
