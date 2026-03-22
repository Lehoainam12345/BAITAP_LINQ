
using System;
using System.Collections.Generic;
using System.Linq;

class SinhVien
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Khoa { get; set; }
    public double DiemTB { get; set; }
    public int NamHoc { get; set; }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Ma sinh vien : 2415053122327/n Name:Lê Hoài Nam");
        Console.WriteLine("Class : 24T3");
        Random rand = new Random();

        List<string> khoas = new List<string>
        {
            "Cong nghe so",
            "Cong nghe thong tin",
            "Kinh te",
            "Dien tu"
        };

        List<SinhVien> sv = new List<SinhVien>();

        for (int i = 1; i <= 50; i++)
        {
            sv.Add(new SinhVien
            {
                Id = i,
                Name = "SV" + i,
                Age = rand.Next(18, 25),
                Khoa = khoas[rand.Next(khoas.Count)],
                DiemTB = Math.Round(rand.NextDouble() * 10, 2),
                NamHoc = rand.Next(1, 5)
            });
        }

        int maxAge = sv.Max(s => s.Age);
        int minAge = sv.Min(s => s.Age);

        Console.WriteLine("Tuoi lon nhat: " + maxAge);
        Console.WriteLine("Tuoi nho nhat: " + minAge);

        bool hasCNS = sv.Any(s => s.Khoa == "Cong nghe so");

        Console.WriteLine("Co sinh vien khoa Cong nghe so: " + hasCNS);

        var top10 = sv
            .Where(s => s.Khoa == "Cong nghe so")
            .OrderByDescending(s => s.DiemTB)
            .Take(10);

        Console.WriteLine("\nTop 10 sinh vien diem cao nhat khoa Cong nghe so:");

        foreach (var s in top10)
        {
            Console.WriteLine($"{s.Name} - {s.DiemTB}");
        }

        var svConLai = sv.Where(s => s.NamHoc != 4);

        Console.WriteLine("\nDanh sach sinh vien khong phai nam cuoi:");

        foreach (var s in svConLai)
        {
            Console.WriteLine($"{s.Name} - Nam {s.NamHoc}");
        }
        Console.ReadLine();
    }
}