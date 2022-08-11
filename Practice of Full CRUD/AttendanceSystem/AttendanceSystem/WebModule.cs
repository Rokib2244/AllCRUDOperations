using AttendanceSystem.Areas.Admin.Models;
using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AttendanceSystem
{
    public class WebModule : Module
    {
        //private readonly string _connectionString;
        //private readonly string _migrationAssemblyName;
        //public WebModule()
        //{

        //}
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CreateStudentModel>().AsSelf();
            //builder.Register<>()
        }
    }
}
