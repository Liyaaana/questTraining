using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qst13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            string vowels = "aeiouAEIOU";

            foreach (char c in input)
            {
                if (vowels.Contains(c))
                {
                    Console.Write(c + " ");
                }
            }
        }
    }
}
