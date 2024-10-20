using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathDelegate
{
    internal class Program
    {
        delegate void MathDelegate(int x, int y);
        static void Add(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        static void Sub(int x, int y)
        {
            Console.WriteLine(x - y);
        }

        static void Main(string[] args)
        {
            MathDelegate del = Add;
            del += Sub;
            del -= Sub;
            del(1, 2);
        }
    }
}
