using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketBookingSystem3.Training
{
   public class TrainingModule : Module
    {

        private readonly string _connectionString;
        private readonly string _migrationAssemblyName;

public TrainingModule(string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }
        protected override void Load(ContainerBuilder builder)
        {
            //builder.RegisterType<TracksModel>().AsSelf();
            //builder.RegisterType<CourseBatchModel>().AsSelf();
            //builder.RegisterType<ReferralModel>().AsSelf();
            //builder.RegisterType<CourseModel>().AsSelf();
            //builder.RegisterType<DataTablesAjaxRequestModel>().As<IDataTablesAjaxRequestModel>()
            //.InstancePerLifetimeScope();
            base.Load(builder);
        }
    }
}
