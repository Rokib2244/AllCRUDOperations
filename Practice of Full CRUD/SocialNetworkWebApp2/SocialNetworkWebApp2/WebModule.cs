using Autofac;
using SocialNetworkWebApp2.Areas.Admin.Models;
using SocialNetworkWebApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialNetworkWebApp2
{
    public class WebModule : Module
    {
        
        protected override void Load(ContainerBuilder builder)
        {
            //builder.RegisterType<TracksModel>().AsSelf();
            //builder.RegisterType<CourseBatchModel>().AsSelf();
            //builder.RegisterType<ReferralModel>().AsSelf();
            //builder.RegisterType<CourseModel>().AsSelf();
            builder.RegisterType<DataTablesAjaxRequestModel>().AsSelf()
            .InstancePerLifetimeScope();
            builder.RegisterType<CreateMemberModel>().AsSelf();
            base.Load(builder);
        }
    }
}
