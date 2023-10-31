using BusinessObject.Models;

namespace Repositories
{
    public interface IMemberRepository
    {
        IEnumerable<Member> GetMembersList();
        Member Login(string email, string password);
        Member GetMember(int memberId);
        Member GetMember(string memberEmail);
        int GetNextMemberId();
        void AddMember(Member member);
        void Update(Member member);
        void Delete(int MemberId);
        IEnumerable<Member> FilterMemberByCountry(string country, IEnumerable<Member> searchList = null);
        IEnumerable<Member> FilterMemberByCity(string country, string city, IEnumerable<Member> searchList);
    }
}
