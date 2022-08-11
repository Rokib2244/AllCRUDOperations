using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketBookingSystem2.Data;
using TicketBookingSystem2.Training.Repositories;
using TicketBookingSystem2.Training.Contexts;

namespace TicketBookingSystem2.Training.UnitOfWorks
{
    public class TrainingUnitOfWork : UnitOfWork, ITrainingUnitOfWork
    {
        public ICustomerRepository Customer { get; private set; }
        public TrainingUnitOfWork( TrainingContext context, 
            ICustomerRepository customer) : base(context)
        {
            Customer = customer;
        }
    }
}
