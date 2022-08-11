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
    public class CustomerListModel
    {
        private readonly ICustomerService _customerService;
        private readonly IMapper _mapper;
        public IList<Customer> Customers { get; set; }
        public CustomerListModel()
        {
            _customerService = Startup.AutofacContainer.Resolve<ICustomerService>();
            _mapper = Startup.AutofacContainer.Resolve<IMapper>();
        }
        public void LoadAllCustomers()
        {
            Customers = _customerService.GetAllCustomes();
        }

    }
}
