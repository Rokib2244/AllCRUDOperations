using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketBookingSystem2.Data;
using TicketBookingSystem2.Training.Contexts;
using TicketBookingSystem2.Training.Entities;

namespace TicketBookingSystem2.Training.Repositories
{
    public class CustomerRepository : Repository<Customer, int>, ICustomerRepository
    {
        public CustomerRepository(TrainingContext context) : base((DbContext)context)
        {

        }
    }
}
