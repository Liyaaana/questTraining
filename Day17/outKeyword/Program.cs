using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace outKeyword
{
    internal class Program
    {
        static void DoThis(out int num)
        {
            num = 0;
        }
        static void Main(string[] args)
        {
            int number;
            DoThis(out number);
            Console.WriteLine(number);

        }
    }
}
