using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketBookingSystem2.Data;

namespace TicketBookingSystem2.Training.Entities
{
    public class Customer : IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double ContactNumber { get; set; }
        public double Age { get; set; }
        public string Address { get; set; }


    }
}
