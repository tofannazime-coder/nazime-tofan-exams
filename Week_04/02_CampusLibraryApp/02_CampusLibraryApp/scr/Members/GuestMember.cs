namespace _02_CampusLibraryApp.scr.Members;

public class GuestMember : Member
{
    public GuestMember(string memberId, string fullName)
        : base(memberId, fullName)
    {
    }

    public override int MaxBooks => 1;

    public override int LoanPeriodDays => 7;

    public override decimal CalculateLateFee(int daysLate)
    {
        return daysLate * 10;
    }

    public override string GetMemberType()
    {
        return "Misafir";
    }
}
