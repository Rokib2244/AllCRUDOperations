using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialNetworkWebApp2.Training.Contexts;
using SocialNetworkWebApp2.Training.Repositories;
using SocialNetworkWebApp2.Training.Services;
using SocialNetworkWebApp2.Training.UnitOfWorks;

namespace SocialNetworkWebApp2.Training
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
            builder.RegisterType<TrainingContext>()
                .AsSelf()
                .WithParameter("connectionString", _connectionString)
                .WithParameter("migrationAssemblyName", _migrationAssemblyName)
                .InstancePerLifetimeScope();
            builder.RegisterType<TrainingContext>()
                .As<ITrainingContext>()
                .WithParameter("connectionString", _connectionString)
                .WithParameter("migrationAssemblyName", _migrationAssemblyName)
                .InstancePerLifetimeScope();
            //builder.RegisterType<CourseBatchModel>().AsSelf();
            //builder.RegisterType<ReferralModel>().AsSelf();
            //builder.RegisterType<CourseModel>().AsSelf();
            builder.RegisterType<MemberRepsitory>().As<IMemberRepsitory>()
            .InstancePerLifetimeScope();
            builder.RegisterType<MemberService>().As<IMemberService>()
            .InstancePerLifetimeScope();
            builder.RegisterType<TrainingUnitOfWork>().As<ITrainingUnitOfWork>()
            .InstancePerLifetimeScope();
            base.Load(builder);
        }
    }
}
