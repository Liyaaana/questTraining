using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qst5
{
    // 5: Define a delegate Operation that takes two integers as parameters.
    // Write methods Add and Multiply that match this delegate signature.
    // Demonstrate how to use the delegate to call these methods.

    internal class Program
    {
        delegate int AddDelegate(int a, int b);
        public static int Add(int a, int b) => a + b;
        public static int Multiply(int a, int b) => a * b;  
        static void Main(string[] args)
        {
            AddDelegate ad = Add;
            Console.WriteLine(ad(12, 18));

            ad += Multiply;
            Console.WriteLine(ad(12, 18));
        }
    }
}
