using Autofac;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using TicketBookingSystem.Training.BussinessObjects;
using TicketBookingSystem.Training.Sercvices;

namespace TicketBookingSystem.Areas.Admin.Models
{
   
    public class EditCustomerModel
    {
        private readonly ICustomerService _customerService;
        private readonly IMapper _mapper;
        public EditCustomerModel()
        {
            _customerService = Startup.AutofacContainer.Resolve<ICustomerService>();
            _mapper = Startup.AutofacContainer.Resolve<IMapper>();
        }
        public EditCustomerModel(ICustomerService customerService, IMapper mapper)
        {
            _customerService = customerService;
            _mapper = mapper;
        }
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public double Age { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }
     

        public void LoadCustomerData(int id)
        {
            var customer = _customerService.GetCustomerById(id);
            _mapper.Map(customer, this);
        }

        internal void UpdateCustomer()
        {
            var customer = _mapper.Map<Customer>(this);
            _customerService.UpdateCustomer(customer);
        }

      
    }
}
