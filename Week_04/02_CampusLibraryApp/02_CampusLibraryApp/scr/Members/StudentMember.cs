namespace _02_CampusLibraryApp.scr.Members;

public class StudentMember : Member
{
    public StudentMember(string memberId, string fullName)
        : base(memberId, fullName)
    {
    }

    public override int MaxBooks => 3;

    public override int LoanPeriodDays => 14;

    public override decimal CalculateLateFee(int daysLate)
    {
        return daysLate * 5;
    }

    public override string GetMemberType()
    {
        return "Öğrenci";
    }
}