
namespace Odev25_Student.Models;

public class Student
{
    public Student(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public String FirstName { get; }
    public String LastName { get; }
    public String StudentNumber { get; set; } = string.Empty;
    public String Department { get; set; }= string.Empty;
}