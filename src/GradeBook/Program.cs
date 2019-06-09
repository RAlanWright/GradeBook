using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            // double[] numbers = new double[3];
            // var numbers = new[] {12.7, 41.5, 23.9};
            
            var grades = new List<double>() {79.8, 100.0, 92.3};
            grades.Add(88.5);

            var result = 0.0;
            foreach(var number in grades)
            {
                result += number;
            }
            
            var average = 0.0;
            average = result / grades.Count;
            Console.WriteLine(average);


            if (args.Length > 0)
            {
            Console.WriteLine($"Hello {args[0]}!");
            }
            else
            {
                Console.WriteLine("Hello!");
            }
        }
    }
}
