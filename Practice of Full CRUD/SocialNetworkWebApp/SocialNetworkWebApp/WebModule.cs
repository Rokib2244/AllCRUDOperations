using Autofac;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialNetworkWebApp
{
    public class WebModule : Module
    {
       

        protected override void Load(ContainerBuilder builder)
        {

            //builder.RegisterType<TracksModel>().AsSelf();



            //builder.RegisterType<DataTablesAjaxRequestModel>().As<IDataTablesAjaxRequestModel>()
            //    .InstancePerLifetimeScope();

            base.Load(builder);

        }
    }
}
