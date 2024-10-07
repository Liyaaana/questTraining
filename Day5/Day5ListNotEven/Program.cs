using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5ListNotEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>();
            Console.Write("Enter 5 number: ");
            for (int i = 0; i < 5; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));
            }
         
            for(int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 == 0)
                {
                    list.RemoveAt(i);
                }
            }
            Console.WriteLine(string.Join(",", list));
           
        }
    }
}
