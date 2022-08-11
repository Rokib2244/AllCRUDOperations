using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketBookingSystem2.Training.BusinessObjects;

namespace TicketBookingSystem2.Training.Services
{
    public interface ICustomerService
    {
        void CreateCustomer(Customer customer);
    }
}
