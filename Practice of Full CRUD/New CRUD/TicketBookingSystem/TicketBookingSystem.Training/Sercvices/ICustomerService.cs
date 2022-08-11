using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketBookingSystem.Training.BussinessObjects;
using TicketBookingSystem.Training.UnitOfWorks;

namespace TicketBookingSystem.Training.Sercvices
{
    public interface ICustomerService
    {
        void CreateCustomer(Customer customer);
        IList<Customer> GetAllCustomes();
        object GetCustomerById(int id);
        void UpdateCustomer(Customer customer);
        void DeleteCustomer(int id);
    }
}
