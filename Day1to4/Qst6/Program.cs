using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qst6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder names = new StringBuilder("name1, name2, name3");

            Console.WriteLine(names.ToString());

            string[] individualNames = names.ToString().Split(',');

            for (int i = 0; i < individualNames.Length; i++)
            {
                Console.WriteLine($"{individualNames[i]} is {i} years old.");
            }
        }
    }
}
