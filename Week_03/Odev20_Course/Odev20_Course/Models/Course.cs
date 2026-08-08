using System;

namespace Odev20_Course.Models;

public class Course
{
    public Course(string? courseCode, string? courseName, string? instructor, int credid, bool isOnline)
    {
        CourseCode = courseCode;
        CourseName = courseName;
        Instructor = instructor;
        Credit = credid;
        IsOnline = isOnline;
    }

    public String CourseCode { get; set; }
    public String CourseName { get; set;}
    public String Instructor { get; set;}
    public int Credit { get; set; }
    public bool IsOnline { get; set;}
}