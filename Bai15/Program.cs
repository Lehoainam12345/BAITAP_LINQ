using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ma sinh vien : 2415053122327/n Name:Lê Hoài Nam");
        Console.WriteLine("Class : 24T3");
        List<int> numbers = new List<int> { 1, 2, 2, 3, 4, 4, 5 };

        var uniqueNumbers = numbers.Distinct();

        Console.WriteLine("Danh sach sau khi loai bo phan tu trung:");

        foreach (var n in uniqueNumbers)
        {
            Console.WriteLine(n);
        }
        Console.ReadLine();
    }
}