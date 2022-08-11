using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketBookingSystem.Training.Services;
using Autofac;

namespace TicketBookingSystem.Areas.Admin.Models
{
    public class EditCustomerModel
    {
        private readonly ICustomerService _customerService;
        public EditCustomerModel()
        {
            _customerService = Startup.AutofacContainer.Resolve<ICustomerService>();
        }

        internal void LoadModelData(int id)
        {
            throw new NotImplementedException();
        }
    }
}
