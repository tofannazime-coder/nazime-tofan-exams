namespace MVC_GymMembers.Models.Entities;

public class Member
{
    public int Id { get; set; }

    public string? FullName { get; set; }

    public string? MembershipType { get; set; }

    public int Age { get; set; }
}