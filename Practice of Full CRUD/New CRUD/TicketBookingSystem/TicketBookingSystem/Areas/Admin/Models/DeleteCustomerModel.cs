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
    public class DeleteCustomerModel
    {
        private readonly ICustomerService _customerService;
        private readonly IMapper _mapper;
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public double Age { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }

       

        public Customer Customer { get; set; }
        public DeleteCustomerModel()
        {
            _customerService = Startup.AutofacContainer.Resolve<ICustomerService>();
            _mapper = Startup.AutofacContainer.Resolve<IMapper>();
        }
        internal void LoadCustomerData(int id)
        {
            var customer = _customerService.GetCustomerById(id);
            _mapper.Map(customer, this);
        }

        internal void DeleteCustomer()
        {
            _customerService.DeleteCustomer(Id);
        }
    }
}
