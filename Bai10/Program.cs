using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }
    }
    static void Main()
    {
        Console.WriteLine("Ma sinh vien : 2415053122327/n Name:Lê Hoài Nam");
        
        Console.WriteLine("Class : 24T3");

        List<Student> students = new List<Student>()
        {
            new Student{Id=1, Name="An", Score=8},
            new Student{Id=2, Name="Binh", Score=6},
            new Student{Id=3, Name="Chi", Score=9},
            new Student{Id=4, Name="Dung", Score=7}
        };

        var sortedStudents = from s in students
                             orderby s.Score descending
                             select s;

        Console.WriteLine("Sinh vien sap xep theo diem giam dan:");

        foreach (var s in sortedStudents)
        {
            Console.WriteLine(s.Name + " - " + s.Score);
        }
        Console.ReadLine();
    }
}