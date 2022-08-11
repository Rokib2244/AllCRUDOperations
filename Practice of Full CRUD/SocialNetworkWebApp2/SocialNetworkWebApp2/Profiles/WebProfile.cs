using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SocialNetworkWebApp2.Areas.Admin.Models;
using SocialNetworkWebApp2.Training.BusinessObjects;

namespace SocialNetworkWebApp2.Profiles
{
    public class WebProfile : Profile
    {
        public WebProfile()
        {
            CreateMap<CreateMemberModel, Member>().ReverseMap();
            CreateMap<EditMemberModel, Member>().ReverseMap();

        }
    }
}
