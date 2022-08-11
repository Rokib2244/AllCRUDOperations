﻿using Microsoft.EntityFrameworkCore;
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
    public class TrainingUitOfWork : UnitOfWork, ITrainingUnitOfWork
    {
        public ICustomerRepository Customers { get; private set; }
        public TrainingUitOfWork( ITrainingContext context, ICustomerRepository customers)
            :base((DbContext)context)
        {
            Customers = customers;
        }
    }
}
