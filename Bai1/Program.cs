using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ma sinh vien : 2415053122327/n Name:Lê Hoài Nam");
        Console.WriteLine("Class : 24T3");
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };

        var evenNumbers = numbers.Where(n => n % 2 == 0);

        foreach (var n in evenNumbers)
       {

       Console.WriteLine(n);
        }
        Console.ReadLine();
    }
}