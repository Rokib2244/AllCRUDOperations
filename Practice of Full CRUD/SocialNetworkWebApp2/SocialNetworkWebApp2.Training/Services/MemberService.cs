using AutoMapper;
using Org.BouncyCastle.Security;
using SocialNetworkWebApp2.Training.BusinessObjects;
using SocialNetworkWebApp2.Training.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetworkWebApp2.Training.Services
{
    public class MemberService : IMemberService
    {
        private readonly ITrainingUnitOfWork _trainingUnitOfWork;
        private readonly IMapper _mapper;
        public MemberService(ITrainingUnitOfWork trainingUnitOfWork,
            IMapper mapper)
        {
            _trainingUnitOfWork = trainingUnitOfWork;
            _mapper = mapper;
        }

        public void CreateMember(Member member)
        {
            if (member == null)
                throw new InvalidParameterException("Course was not provided");
            _trainingUnitOfWork.Members.Add(
                 _mapper.Map<Entities.Member>(member)
                );
            _trainingUnitOfWork.Save();
        }

        public IList<Member> GetAllMembersData()
        {
            var memberEntities = _trainingUnitOfWork.Members.GetAll();
            var members = new List<Member>();
            foreach( var entity in memberEntities)
            {
                var member = _mapper.Map<Member>(entity);
                members.Add(member);
            }
            return members;
        }

        public object GetMember(int id)
        {
            var memberEntity = _trainingUnitOfWork.Members.GetById(id);
            if (memberEntity == null) return null;
            return _mapper.Map<Member>(memberEntity);
          
            
        }

        public void UpdateMember(Member member)
        {
            if (member == null)
                throw new InvalidOperationException("Member was not found");
            if(IsMemberNameAlreadyExist(member.Name, member.Id))
                throw new InvalidOperationException("Member Name already used");
            var memberEntity = _trainingUnitOfWork.Members.GetById(member.Id);
            if(memberEntity != null)
            {
                _mapper.Map(member, memberEntity);
                _trainingUnitOfWork.Save();
            }
        }
        public void DeleteMember(int id)
        {
            _trainingUnitOfWork.Members.Remove(id);
            _trainingUnitOfWork.Save();
        }
        private bool IsMemberNameAlreadyExist(string memberName, int memberid) =>
            _trainingUnitOfWork.Members.GetCount(x => x.Name == memberName && x.Id != memberid) > 0;

        public (IList<Member> records, int total, int totalDisplay) GetAllmembers(int pageIndex, int pageSize,
            string searchText, string sortText)
        {
            var memberData = _trainingUnitOfWork.Members.GetDynamic(
                string.IsNullOrWhiteSpace(searchText)?null: x => x.Name.Contains(searchText), 
                sortText, string.Empty, pageIndex, pageSize) ;
            var resultData = (from member in memberData.data
                              select _mapper.Map<Member>(member)).ToList();
            return (resultData, memberData.total, memberData.totalDisplay);
           
        }
    }
}
