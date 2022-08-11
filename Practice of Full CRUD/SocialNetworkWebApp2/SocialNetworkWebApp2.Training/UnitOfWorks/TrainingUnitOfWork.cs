using SocialNetworkWebApp2.Data;
using SocialNetworkWebApp2.Training.Repositories;
using SocialNetworkWebApp2.Training.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SocialNetworkWebApp2.Training.UnitOfWorks
{
    public class TrainingUnitOfWork : UnitOfWork, ITrainingUnitOfWork
    {
        public IMemberRepsitory Members { get; private set; }
        public TrainingUnitOfWork( ITrainingContext context, IMemberRepsitory members)
            : base((DbContext)context)
        {
            Members = members;
        }
    }
}
