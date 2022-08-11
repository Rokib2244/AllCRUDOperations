using Autofac;
using AutoMapper;
using SocialNetworkWebApp2.Training.BusinessObjects;
using SocialNetworkWebApp2.Training.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialNetworkWebApp2.Areas.Admin.Models
{
    public class CreateMemberModel
    {
        private readonly IMemberService _memberService;
        private readonly IMapper _mapper;
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public CreateMemberModel()
        {
            _memberService = Startup.AutofacContainer.Resolve<IMemberService>();
            _mapper = Startup.AutofacContainer.Resolve<IMapper>();
        }
        public CreateMemberModel(IMemberService memberService, IMapper mapper)
        {
            _memberService = memberService;
            _mapper = mapper;
        }

        internal void CreateMember()
        {
            var member = _mapper.Map<Member>(this);
            _memberService.CreateMember(member);
        }
    }
}
