using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketBookingSystem2.Training.Contexts;
using TicketBookingSystem2.Training.Repositories;
using TicketBookingSystem2.Training.Services;
using TicketBookingSystem2.Training.UnitOfWorks;

namespace TicketBookingSystem2.Training
{
    public class TrainingModule : Module
    {
        private readonly string _connectionStringName;
        private readonly string _migrationAssemblyName;
        public TrainingModule(string connectionStringName, string migrationAssemblyName)
        {
            _connectionStringName = connectionStringName;
            _migrationAssemblyName = migrationAssemblyName;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<TrainingContext>().AsSelf()
                .WithParameter("connectionStringName", _connectionStringName)
                .WithParameter("migrationAssemblyName", _migrationAssemblyName);
            builder.RegisterType<TrainingContext>().As<ITrainingContext>()
               .WithParameter("connectionStringName", _connectionStringName)
               .WithParameter("migrationAssemblyName", _migrationAssemblyName);
            //builder.RegisterType<CourseBatchModel>().AsSelf();
            //builder.RegisterType<ReferralModel>().AsSelf();
            //builder.RegisterType<CourseModel>().AsSelf();
            builder.RegisterType<CustomerRepository>().As<ICustomerRepository>()
            .InstancePerLifetimeScope();
            builder.RegisterType<CustomerService>().As<ICustomerService>()
           .InstancePerLifetimeScope();
            builder.RegisterType<TrainingUnitOfWork>().As<ITrainingUnitOfWork>()
           .InstancePerLifetimeScope();
            base.Load(builder);
        }
    }
}
