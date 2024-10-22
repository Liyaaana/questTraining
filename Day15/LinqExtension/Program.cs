using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqExtension.ExtensionMethods;

namespace LinqExtension
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 2;
            Console.WriteLine(i.IsEvenOrOdd());
            i = 3;
            Console.WriteLine(i.IsEvenOrOdd());

        }
    }
}
