using Autofac;
using TicketBookingSystem.Training.Contexts;
using TicketBookingSystem.Training.Repositories;
using TicketBookingSystem.Training.Services;
using TicketBookingSystem.Training.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketBookingSystem.Training
{
    public class TrainingModule : Module
    {
        private readonly string _connectionString;
        private readonly string _migrationAssemblyName;

        public TrainingModule( string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }

        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterType<TrainingContext>().AsSelf()
                .WithParameter("connectionString", _connectionString)
                .WithParameter("migrationAssemblyName", _migrationAssemblyName)
                .InstancePerLifetimeScope();
            builder.RegisterType<TrainingContext>().As<ITrainingContext>()
               .WithParameter("connectionString", _connectionString)
               .WithParameter("migrationAssemblyName", _migrationAssemblyName)
               .InstancePerLifetimeScope();

            builder.RegisterType<CustomerRepository>().As<ICustomerRepository>()
                .InstancePerLifetimeScope();
            builder.RegisterType<CustomerService>().As<ICustomerService>()
                .InstancePerLifetimeScope();
            builder.RegisterType<TrainingUitOfWork>().As<ITrainingUnitOfWork>()
                .InstancePerLifetimeScope();

            base.Load(builder);

        }
    }
}
