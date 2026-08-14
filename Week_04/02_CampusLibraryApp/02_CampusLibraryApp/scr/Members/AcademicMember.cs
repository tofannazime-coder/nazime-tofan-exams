namespace _02_CampusLibraryApp.scr.Members;

public class AcademicMember : Member
{
    public AcademicMember(string memberId, string fullName)
        : base(memberId, fullName)
    {
    }

    public override int MaxBooks => 10;

    public override int LoanPeriodDays => 30;

    public override decimal CalculateLateFee(int daysLate)
    {
        return daysLate * 2;
    }

    public override string GetMemberType()
    {
        return "Akademisyen";
    }
}