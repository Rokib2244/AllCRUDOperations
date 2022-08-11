using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EO = SocialNetworkWebApp2.Training.Entities;
using BO = SocialNetworkWebApp2.Training.BusinessObjects;

namespace SocialNetworkWebApp2.Training.Profiles
{
    class TrainingProfile : Profile
    {
        public TrainingProfile()
        {
            CreateMap<EO.Member, BO.Member>().ReverseMap();
        }
    }
}
