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
    public class EditMemberModel
    {
        private readonly IMemberService _memberService;
        private readonly IMapper _mapper;
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public EditMemberModel()
        {
            _memberService = Startup.AutofacContainer.Resolve<IMemberService>();
            _mapper = Startup.AutofacContainer.Resolve<IMapper>();
        }
        public void LoadModelData(int id)
        {
            Member member =(Member) _memberService.GetMember(id);
            Id = member.Id;
            Name = member.Name;
            DateOfBirth = member.DateOfBirth;
            Address = member.Address;
            //_mapper.Map(member, this);
        }
        public void Update()
        {
            var member = _mapper.Map<Member>(this);
            _memberService.UpdateMember(member);
        }
   
    }
}
