using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketBookingSystem.Data;
using TicketBookingSystem.Training.Contexts;
using TicketBookingSystem.Training.Repositories;

namespace TicketBookingSystem.Training.UnitOfWorks
{
    public class TrainingUnitOfWork : UnitOfWork, ITrainingUnitOfWork
    {
        public ICustomerRepository Customers { get; private set; }
        private readonly ITrainingContext _context;
        public TrainingUnitOfWork(ITrainingContext context, ICustomerRepository customers):base((DbContext)context)
        {
            _context = context;
            Customers = customers;
        }
    }
}
