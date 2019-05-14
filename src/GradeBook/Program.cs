using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("");
            book.AddGrade(34.1);
            book.AddGrade(23.5);
            book.AddGrade(54.8);
            book.AddGrade(76.9);
            var stats = book.GetStatistics();
            
            Console.WriteLine($"My Lowest grades are {stats.Low}");
            Console.WriteLine($"My highest grades are {stats.High}");
            Console.WriteLine($"My average grades are {stats.Average}");

        }
    }
}
