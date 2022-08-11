using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketBookingSystem.Training.BussinessObjects;
using TicketBookingSystem.Training.UnitOfWorks;

namespace TicketBookingSystem.Training.Sercvices
{
    public class CustomerService:ICustomerService
    {
        private readonly ITrainingUnitOfWork _trainingUnitOfWork;
        private readonly IMapper _mapper;
        public CustomerService(ITrainingUnitOfWork trainingUnitOfWork, IMapper mapper)
        {
            _trainingUnitOfWork = trainingUnitOfWork;
            _mapper = mapper;
        }

        public void CreateCustomer(Customer customer)
        {
            if (customer == null)
                throw new InvalidOperationException("Sorry..Customer was not found");
            if(IsCustomerAlreadyExist(customer.ContactNumber))
                throw new InvalidOperationException("Sorry..Customer was alrady existed..");
            _trainingUnitOfWork.Customers.Add(
                _mapper.Map<Entities.Customer>(customer));
            _trainingUnitOfWork.Save();
        }

        public void DeleteCustomer(int id)
        {
            _trainingUnitOfWork.Customers.Remove(id);
            _trainingUnitOfWork.Save();
        }

        public IList<Customer> GetAllCustomes()
        {
            var customerEntities = _trainingUnitOfWork.Customers.GetAll();
            var customers = new List<Customer>();
            foreach(var entity in customerEntities)
            {
                var customer = _mapper.Map<Customer>(entity);
                customers.Add(customer);
            }
            return customers;
        }

        public object GetCustomerById(int id)
        {
            var customer = _trainingUnitOfWork.Customers.GetById(id);
            return _mapper.Map<Customer>(customer);
        }

        public void UpdateCustomer(Customer customer)
        {
            if (customer == null)
                throw new InvalidOperationException("Sorry..Customer was not found");
            var customerEntity = _trainingUnitOfWork.Customers.GetById(customer.Id);
            if(customerEntity != null)
            {
                _mapper.Map(customer, customerEntity);
                _trainingUnitOfWork.Save();
            }
        }

        bool IsCustomerAlreadyExist(string contactNumber) =>
            _trainingUnitOfWork.Customers.GetCount(x => x.ContactNumber == contactNumber) > 0;
    }
}
