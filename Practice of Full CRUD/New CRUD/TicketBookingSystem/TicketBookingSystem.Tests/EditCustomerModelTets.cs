using Autofac.Extras.Moq;
using AutoMapper;
using Moq;
using NUnit.Framework;
using System.Diagnostics.CodeAnalysis;
using TicketBookingSystem.Areas.Admin.Models;
using TicketBookingSystem.Training.BussinessObjects;
using TicketBookingSystem.Training.Sercvices;

namespace TicketBookingSystem.Tests
{
    [ExcludeFromCodeCoverage]
    public class EditCustomerModelTets
    {
        private AutoMock _mock;
        private Mock<ICustomerService> _customerServiceMock;
        private Mock<IMapper> _mapperMock;
        private EditCustomerModel _model;
        [OneTimeSetUp]
        public void ClassSetup()
        {
            _mock = AutoMock.GetLoose();
        }
        [OneTimeTearDown]
        public void ClassCleanup()
        {
            _mock?.Dispose();
        }
        [SetUp]
        public void TestSetup()
        {
            _customerServiceMock = _mock.Mock<ICustomerService>();
            _mapperMock = _mock.Mock<IMapper>();
            _model = _mock.Create<EditCustomerModel>();
        }
        [TearDown]
        public void TestCleanup()
        {
            _customerServiceMock?.Reset();
            _mapperMock?.Reset();
        }

        [Test]
        public void LoadCustomerData_CustomerExists_LoadProperties()
        {
            //Arrange
            const int id = 5;
            var customer = new Customer {
                Id = 5,
                CustomerName = "Sajjad",
                ContactNumber = "01811217131",
                Address = "Ctg",
                Age = 27
            };
            _customerServiceMock.Setup(x => x.GetCustomerById(id)).Returns(customer);
            _mapperMock.Setup(x => x.Map<EditCustomerModel>(It.IsAny<Customer>()))
                .Returns((Customer customer) => {
                    return new EditCustomerModel { Id = customer.Id };
                });
            //Act
            _model.LoadCustomerData(id);
            //Assert
            Assert.AreEqual(id, _model.Id);
        }
    }
}