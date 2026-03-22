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
            new Student{Id=4, Name="Dung", Score=7}
        };

        var groups = students.GroupBy(s =>
        {
            if (s.Score >= 8) return "Gioi";
            else if (s.Score >= 6) return "Kha";
            else return "Trung binh";
        });

        foreach (var group in groups)
        {
            Console.WriteLine("Xep loai: " + group.Key);

            foreach (var s in group)
            {
                Console.WriteLine(s.Name + " - " + s.Score);
            }

            Console.WriteLine();
        }
        Console.ReadLine();
    }
}