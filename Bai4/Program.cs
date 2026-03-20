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

        var sortedNumbers = from n in numbers
                            orderby n descending
                            select n;

        foreach (var n in sortedNumbers)
        {
            Console.WriteLine(n);
        }
        Console.ReadLine();
    }
}