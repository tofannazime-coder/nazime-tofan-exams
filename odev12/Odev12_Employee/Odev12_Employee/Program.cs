using System;
using Odev12_Employee.Models;

namespace Odev12_Employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee b1 = new Employee {FullName = "Nazlı Tofan" , Title = "Uzman" , Department="Yazılım", HireDate=DateTime.Now.AddMonths(-1)};
            Employee b2 = new Employee {FullName = "Hatice Kübra Kaya" , Title = "Bilgisayar Proğramcılığı" , Department="Yazılım Geliştirme", HireDate=DateTime.Now.AddYears(-2)};
            Employee b3 = new Employee {FullName = "Baran Bal" , Title = "İşletme Öğrencisi" , Department="Yönetim ve Organizasyon", HireDate=DateTime.Now.AddMonths(-7)};

            Employee[] employees = {b1 , b2 , b3};

            foreach(var employee in employees)
            {
                Console.WriteLine($" Çalışan: {employee.FullName} | Unvan: {employee.Title} | Departman: {employee.Department}");
            }
        }
    }
}