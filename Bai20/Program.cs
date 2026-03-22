
using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Score { get; set; }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Ma sinh vien : 2415053122327/n Name:Lê Hoài Nam");
        Console.WriteLine("Class : 24T3");
        List<Student> students = new List<Student>()
        {
            new Student{Id=1, Name="An", Score=8},
            new Student{Id=2, Name="Binh", Score=6},
            new Student{Id=3, Name="Chi", Score=9},
            new Student{Id=4, Name="Dung", Score=7},
            new Student{Id=5, Name="Hoa", Score=8.5}
        };

        var top3 = students
                    .OrderByDescending(s => s.Score)
                    .Take(3);

        Console.WriteLine("Top 3 sinh vien diem cao nhat:");

        foreach (var s in top3)
        {
            Console.WriteLine(s.Name + " - " + s.Score);
        }
        Console.ReadLine();
    }
}