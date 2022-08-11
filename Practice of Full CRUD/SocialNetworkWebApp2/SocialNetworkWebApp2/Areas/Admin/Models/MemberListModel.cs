using Autofac;
using AutoMapper;
using SocialNetworkWebApp2.Models;
using SocialNetworkWebApp2.Training.BusinessObjects;
using SocialNetworkWebApp2.Training.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialNetworkWebApp2.Areas.Admin.Models
{
    public class MemberListModel
    {
        private readonly IMemberService _memberService;
        private readonly IMapper _mapper;
        public IList<Member> Members { get; set; }
        public MemberListModel()
        {
            _memberService = Startup.AutofacContainer.Resolve<IMemberService>();
            _mapper = Startup.AutofacContainer.Resolve<IMapper>();
        }
        public MemberListModel(IMemberService memberService, IMapper mapper)
        {
            _memberService = memberService;
            _mapper = mapper;
        }

        internal void LoadMemberData()
        {
            Members = _memberService.GetAllMembersData();
        }

        internal object GetAllMembers(DataTablesAjaxRequestModel dataTablesModel)
        {
            var data = _memberService.GetAllmembers(
                dataTablesModel.PageIndex,
                dataTablesModel.PageSize,
                dataTablesModel.SearchText,
                dataTablesModel.GetSortText(new string[] { "Name", "DateOfBirth", "Address" }
                ));
            return new {
                //recordsTotal = data.total,
                //recordsFiltered = data.totalDisplay,
                //data = (from record in data.records)

            };
            throw new NotImplementedException();
        }
    }
}
