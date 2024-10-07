using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5ArrayofListMarks
{
    internal class Program
    {
        static void NestedList()
        {
            var list = new List<List<int>>();
            list.Add(new List<int>());
            list[0].Add(1);
            list[0].Add(2);

            var list1 = new List<List<int>>
            {
                new List<int>{1, 2},
                new List<int>{3, 4}
            };

            // Same as.....
            var t = new List<int> {1, 2, 3};
        }
        static void Main(string[] args)
        {
            List<int>[] data = new List<int>[2];
            for (int i = 0; i < 2; i++)
            {
                data[i] = new List<int>();
                for (int j = 1; j <= 3; j++)
                {
                    Console.Write($"Enter mark {j}: ");
                    int mark = int.Parse(Console.ReadLine());
                    data[i].Add(mark);
                }
            }

            // Display the array of lists
            Console.WriteLine("Entered marks:");
            for (int i = 0; i < data.Length; i++)
            {
                foreach (int mark in data[i])
                {
                    Console.Write(mark + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
