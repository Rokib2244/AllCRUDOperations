using SocialNetworkWebApp2.Training.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetworkWebApp2.Training.Services
{
    public interface IMemberService
    {
        void CreateMember(Member member);
        IList<Member> GetAllMembersData();
        object GetMember(int id);
        void UpdateMember(Member member);
        (IList<Member> records, int total, int totalDisplay) GetAllmembers(int pageIndex, int pageSize, string searchText, string sortText);
    }
}
