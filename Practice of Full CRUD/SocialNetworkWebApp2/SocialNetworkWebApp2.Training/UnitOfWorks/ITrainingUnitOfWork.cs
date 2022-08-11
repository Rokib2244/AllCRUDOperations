using SocialNetworkWebApp2.Data;
using SocialNetworkWebApp2.Training.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetworkWebApp2.Training.UnitOfWorks
{
   public interface ITrainingUnitOfWork : IUnitOfWork
    {
        IMemberRepsitory Members { get; }
    }
}
