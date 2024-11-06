using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseWithoutBuiltin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 123;
            int reverse = 0;

            while (n > 0)
            {
                int remainder = n % 10;
                reverse = reverse * 10 + remainder;
                n = n / 10;
            }
            Console.WriteLine(reverse);
        }
    }
}
