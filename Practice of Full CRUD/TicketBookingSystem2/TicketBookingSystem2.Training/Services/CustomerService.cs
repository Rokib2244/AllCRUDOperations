using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Org.BouncyCastle.Security;
using TicketBookingSystem2.Training.BusinessObjects;
using TicketBookingSystem2.Training.UnitOfWorks;

namespace TicketBookingSystem2.Training.Services
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
            if(customer == null)            
                throw new InvalidParameterException("Product was not provided");
            if(IsCustomerAlreadyExist(customer.ContactNumber))
                throw new InvalidParameterException("Customer Already Exist");       
            _trainingUnitOfWork.Customer.Add(
                /* _mapper.Map<Entities.Customer>(customer)*/
                new Entities.Customer
                {
                    Name = customer.Name,
                    ContactNumber = customer.ContactNumber,
                    Age = customer.Age,
                    Address = customer.Address
                });
            _trainingUnitOfWork.Save();
        }
        public bool IsCustomerAlreadyExist(double contactNumber) =>
            _trainingUnitOfWork.Customer.GetCount( x => x.ContactNumber == contactNumber) >0;

    }
}
