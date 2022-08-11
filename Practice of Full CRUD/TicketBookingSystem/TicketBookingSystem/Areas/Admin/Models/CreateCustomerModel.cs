using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketBookingSystem.Training.Services;
using TicketBookingSystem.Training.BusinessObjects;
using Autofac;
using AutoMapper;

namespace TicketBookingSystem.Areas.Admin.Models
{
    public class CreateCustomerModel
    {
        public string Name { get; set; }
        public double Age { get; set; }
        public string Address { get; set; }

        private readonly ICustomerService _customerService;
        private readonly IMapper _mapper;
        public CreateCustomerModel()
        {
            _customerService = Startup.AutofacContainer.Resolve<ICustomerService>();
            _mapper = Startup.AutofacContainer.Resolve<IMapper>();
        }
        public CreateCustomerModel( ICustomerService customerService)
        {
            _customerService = customerService;

        }

        internal void CreateCustomer()
        {
            //var customer = new Customer
            //{
            //    Name = Name,
            //    Age = Age,
            //    Address = Address
            //};
            var customer = _mapper.Map<Customer>(this);
            _customerService.CreateCustomer(customer);
        }
        

    }
}
