using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            // var list = new List<int>();

            // Adds a single elememnt.
            list.Add(10);

            // Adding multiple values.
            var valuesToAdd = new int[] { 20, 30, 40, 50, 50 };
            list.AddRange(valuesToAdd);

            // updating the element.
            list[0] = 100;

            // Removing the first occurance of 50.
            list.Remove(50);

            // Removing from a specific index.
            list.RemoveAt(1);

            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + ",");
            }
            Console.WriteLine();
            foreach (var item in list)
            {
                Console.Write(item + ",");
            }

        }
    }
}
