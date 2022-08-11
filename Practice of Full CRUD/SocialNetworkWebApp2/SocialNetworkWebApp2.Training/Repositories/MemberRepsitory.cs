using Microsoft.EntityFrameworkCore;
using SocialNetworkWebApp2.Data;
using SocialNetworkWebApp2.Training.Contexts;
using SocialNetworkWebApp2.Training.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetworkWebApp2.Training.Repositories
{
    public class MemberRepsitory : Repository<Member, int>, IMemberRepsitory
    {
        public MemberRepsitory( ITrainingContext context):base((DbContext)context)
        {
                
        }
    }
}
