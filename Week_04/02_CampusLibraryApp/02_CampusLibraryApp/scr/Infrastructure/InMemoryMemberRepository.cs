using _02_CampusLibraryApp.scr.Interfaces;
using _02_CampusLibraryApp.scr.Members;

namespace _02_CampusLibraryApp.scr.Infrastructure;

public class InMemoryMemberRepository : IRepository<Member>
{
    private readonly List<Member> _members = new();

    public void Add(Member member)
    {
        if (_members.Any(x => x.MemberId == member.MemberId))
            throw new InvalidOperationException(
                $"'{member.MemberId}' ID'li üye zaten mevcut.");

        _members.Add(member);
    }

    public Member? GetById(string id)
    {
        return _members.FirstOrDefault(x => x.MemberId == id);
    }

    public Member[] GetAll()
    {
        return _members.ToArray();
    }

    public void Delete(string id)
    {
        Member? member = GetById(id);

        if (member != null)
        {
            _members.Remove(member);
        }
    }
}