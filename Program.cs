using Studentcpp;
using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>()
        {
            new Student(1, "Han", 16),
            new Student(2, "Tran", 18),
            new Student(3, "Lan Phuong", 14),
            new Student(4, "Loan", 17),
            new Student(5, "A Tuan", 19)
        };

        // a. In toan bo danh sach
        Console.WriteLine("a. Danh sach học sinh:");
        students.ForEach(s => Console.WriteLine($"{s.Id} - {s.Name} - {s.Age}"));

        Console.WriteLine("\n-----------------------------------");

        // b. Hoc sinh tuoi từ 15–18 
        var hs1518 = students.Where(s => s.Age >= 15 && s.Age <= 18);
        Console.WriteLine("b. Học sinh tu 15 den 18 tuoi:");
        hs1518.ToList().ForEach(s => Console.WriteLine($"{s.Id} - {s.Name} - {s.Age}"));

        Console.WriteLine("\n-----------------------------------");

        // c. Tên bat dau bang chu A
        var nameA = students.Where(s => s.Name.StartsWith("A"));
        Console.WriteLine("c. Hoc sinh ten bat dau bang A:");
        nameA.ToList().ForEach(s => Console.WriteLine($"{s.Id} - {s.Name} - {s.Age}"));

        Console.WriteLine("\n-----------------------------------");

        // d. Tổng tuổi
        int totalAge = students.Sum(s => s.Age);
        Console.WriteLine($"d. Tong tuoi hoc sinh: {totalAge}");

        Console.WriteLine("\n-----------------------------------");

        // e. Học sinh lớn tuổi nhất
        int maxAge = students.Max(s => s.Age);
        var oldest = students.Where(s => s.Age == maxAge);
        Console.WriteLine("e. Học sinh lon tuoi nhat:");
        oldest.ToList().ForEach(s => Console.WriteLine($"{s.Id} - {s.Name} - {s.Age}"));

        Console.WriteLine("\n-----------------------------------");

        // f. Sắp xếp tuổi tăng dần
        var sorted = students.OrderBy(s => s.Age);
        Console.WriteLine("f. Danh sach sau khi sap xep tuoi tang dan:");
        sorted.ToList().ForEach(s => Console.WriteLine($"{s.Id} - {s.Name} - {s.Age}"));

        Console.ReadLine();
    }
}
