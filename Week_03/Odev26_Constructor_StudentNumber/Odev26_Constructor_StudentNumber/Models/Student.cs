namespace Odev26_Constructor_StudentNumber.Models
{
    public class Student
    {
        public int StudentNumber { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public double Gpa { get; set; }

        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

        }
        public Student(int studentNumber, string firstName, string lastName)
        {
            StudentNumber = studentNumber;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}