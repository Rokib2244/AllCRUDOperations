using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketBookingSystem2.Data;
using TicketBookingSystem2.Training.Entities;

namespace TicketBookingSystem2.Training.Repositories
{
   public interface ICustomerRepository : IRepository<Customer, int>
    {
    }
}
