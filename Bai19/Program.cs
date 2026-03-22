
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ma sinh vien : 2415053122327/n Name:Lê Hoài Nam");
        Console.WriteLine("Class : 24T3");
        List<int> numbers = new List<int> { 1, 2, 2, 3, 3, 3, 4, 4 };

        var mostFrequent = numbers
            .GroupBy(n => n)
            .OrderByDescending(g => g.Count())
            .First()
            .Key;

        Console.WriteLine("So xuat hien nhieu nhat: " + mostFrequent);
        Console.ReadLine();
    }
}