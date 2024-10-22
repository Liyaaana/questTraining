using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qstns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var evenNum = num.Where(n => n % 2 == 0).ToList();

            var strings = new List<string> { "Apple", "Apricot", "Cherry", "Avocado" };
            var startsWithA = strings.Where(s => s.StartsWith("A")).ToList();

            var descNum = num.OrderByDescending(n => n).ToList();

            var Sqr = num.Select( n => n * n).ToList();

            var evenSqr = num.Where(n => n % 2 == 0).Select(n => n * n).ToList();

            /*
            var firstWithB = strings.FirstOrDefault(s => s.StartsWith("B"));
            if (firstWithB != null)
            {
                Console.WriteLine($"First string starting with 'B': {firstWithB}");
            }
            else
            {
                Console.WriteLine("Nothing.");
            }
            */

            /*
            //Qst7
            List<string> studentNames = new List<string>() { "Anu", "Arya", "Kavya", "Manu" };
            List<int> studentGrades = new List<int>() { 85, 78, 90, 65 };

            var studentsAbove80 = studentNames.Where((name, grade) => studentGrades[grade] > 80).ToList();
            Console.WriteLine("Students scoring above 80: " + string.Join(", ", studentsAbove80));
            */

            //Qst7 using .Zip
            var names = new List<string>() { "S1", "S2", "S3" };
            var marks = new List<int>() { 80, 90, 85 };
            var res = names
                .Zip(marks, (name, mark) => { return new { name, mark }; })
                .Where(s => s.mark > 80)
                .Select(s => s.name);

            foreach (var item in res)
            {
                Console.WriteLine(item);
            }


            var groupedByLength = strings.GroupBy(s => s.Length).ToList();

            var maxValue = num.Max();
            var minValue = num.Min();

            var greateThanFifty = num.Where(n => n > 50);

            var allPositive = num.All(n => n > 0);

            var sum = num.Sum();

            var average = num.Average();

            var distinctNumbers = num.Distinct().ToList();

            var countGreaterThanTen = num.Count(n => n > 10);


            //Qst19
            var result = num.Skip(5).Take(3).ToList();

            //Qst20
            List<int> list1 = new List<int> { 1, 2, 3 };
            List<string> list2 = new List<string> { "A", "B", "C" };
            var zippedPairs = list1.Zip(list2, (number, str) => new { Number = number, Text = str });

            foreach (var pair in zippedPairs)
            {
                Console.WriteLine($"Number: {pair.Number}, Text: {pair.Text}");
            }

         

        }
    }
}
