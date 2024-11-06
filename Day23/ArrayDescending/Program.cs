using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDescending
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 2, 8, 1, 3 };
            var numbersDescending = numbers.OrderByDescending(n => n).ToArray();
            Console.WriteLine("Array sorted in descending order:");
            foreach (int number in numbersDescending)
            {
                Console.Write(number + " ");
            }
        }
    }
}