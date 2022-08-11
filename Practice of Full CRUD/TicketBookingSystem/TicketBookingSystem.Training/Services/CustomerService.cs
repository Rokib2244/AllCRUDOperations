using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketBookingSystem.Training.BusinessObjects;
using TicketBookingSystem.Training.UnitOfWorks;

namespace TicketBookingSystem.Training.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ITrainingUnitOfWork _trainingUnitOfWork;
        private readonly IMapper _mapper;
        public CustomerService( ITrainingUnitOfWork trainingUnitOfWork,
            IMapper mapper)
        {
            _trainingUnitOfWork = trainingUnitOfWork;
            _mapper = mapper;
        }

        public void CreateCustomer(Customer customer)
        {
            if (customer == null)
                throw new InvalidOperationException("customer was not found");
            _trainingUnitOfWork.Customers.Add(
                _mapper.Map<Entities.Customer>(customer)
                );
            _trainingUnitOfWork.Save();
        }

        public  (IList<Customer> records, int total, int totalDisplay) GetCustomers( int pageIndex, int pageSize, 
            string searchText, string sortText)
        {
            var cutomerData = _trainingUnitOfWork.Customers.GetDynamic(
                string.IsNullOrWhiteSpace(searchText) ? null : x => x.Name.Contains(sortText), sortText, string.Empty,
                pageIndex, pageSize );
            var resultData = (from customer in cutomerData.data
                              select new Customer
                              {
                                  Name = customer.Name,
                                  Address = customer.Address,
                                  Age = customer.Age
                              }).ToList();
            return (resultData, cutomerData.total, cutomerData.totalDisplay);
        }
    }
}
