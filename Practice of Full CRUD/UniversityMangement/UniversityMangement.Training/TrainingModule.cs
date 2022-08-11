using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityMangement.Training
{
   public class TrainingModule : Module
    {
        private readonly string _connecationString;
        private readonly string _migrationAssemblyName;
        public TrainingModule(string connecationString, string migrationAssemblyName)
        {
            _connecationString = connecationString;
            _migrationAssemblyName = migrationAssemblyName;
        }
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
        }
    }
}
