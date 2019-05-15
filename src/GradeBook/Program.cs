using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Shujat Grade book");
            var done = false;
            while (!done)
            {
                Console.WriteLine("Please enter the Grade or 'q' to quit");
                var input = Console.ReadLine();

                if (input == "q")
                    break;

                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("******");
                }
            }
            // book.AddGrade(34.1);
            // book.AddGrade(23.5);
            // book.AddGrade(54.8);
            // book.AddGrade(76.9);
            var stats = book.GetStatistics();

            Console.WriteLine($"My Lowest grades are {stats.Low}");
            Console.WriteLine($"My highest grades are {stats.High}");
            Console.WriteLine($"My average grades are {stats.Average}");
            Console.WriteLine($"My Grade Letter is {stats.Letter}");

        }
    }
}
