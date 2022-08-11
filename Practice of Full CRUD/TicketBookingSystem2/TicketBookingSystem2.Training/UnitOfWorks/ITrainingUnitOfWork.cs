using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketBookingSystem2.Data;
using TicketBookingSystem2.Training.Repositories;

namespace TicketBookingSystem2.Training.UnitOfWorks
{
   public interface ITrainingUnitOfWork : IUnitOfWork
    {
        ICustomerRepository Customer { get; }
    }
}
