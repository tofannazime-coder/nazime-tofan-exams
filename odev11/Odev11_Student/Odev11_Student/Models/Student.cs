using System;

namespace Odev11_Student.Models;

public class Student
{
    public String FirstName { get; set; }
    public String LastName { get; set; }
    public int StudentNumber { get; set; }
    public String Department { get; set; }

    public Student()
    {
        FirstName = "";
        LastName = "";
        StudentNumber = 0;
        Department = "";
    }
}