﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketBookingSystem.Data;

namespace TicketBookingSystem.Training.Entities
{
    public class Customer : IEntity<int>
    {
        public int Id { get ; set; }
        public string CustomerName { get; set; }
        public double Age { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }

    }
}
