using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoutResize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] originalArray = { 1, 2, 3 };
            List<int> list = new List<int>(originalArray);
            list.Add(4);
            list.Add(5);
            int[] newArray = list.ToArray();
            Console.WriteLine("New array elements:");
            foreach (int element in newArray)
            {
                Console.WriteLine(element);
            }
        }
    }
}
