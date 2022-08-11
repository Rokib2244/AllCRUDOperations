using Autofac;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketBookingSystem.Training.BussinessObjects;
using TicketBookingSystem.Training.Sercvices;

namespace TicketBookingSystem.Areas.Admin.Models
{
    public class CreateCustomerModel
    {
        private readonly ICustomerService _customerService;
        private readonly IMapper _mapper;
        public CreateCustomerModel()
        {
            _customerService = Startup.AutofacContainer.Resolve<ICustomerService>();
            _mapper = Startup.AutofacContainer.Resolve<IMapper>();
        }
        public string CustomerName { get; set; }
        public double Age { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }

        internal void CreateCustomer()
        {
            var customer = _mapper.Map<Customer>(this);
            _customerService.CreateCustomer(customer);
        }
    }
}
