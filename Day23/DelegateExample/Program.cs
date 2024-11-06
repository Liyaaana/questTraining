using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{
    public delegate int MyDelegate(int x, int y);

    class Program
    {
        public static int Calculate(int a, int b, MyDelegate operation)
        {
            return operation(a, b);
        }

        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Multiply(int x, int y)
        {
            return x * y;
        }

        static void Main(string[] args)
        {
            int resultAdd = Calculate(5, 3, Add);
            Console.WriteLine("Addition Result: " + resultAdd);

            int resultMultiply = Calculate(5, 3, Multiply);
            Console.WriteLine("Multiplication Result: " + resultMultiply);
        }
    }
}

namespace DelagateCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> add = (x, y) => x + y;
            Func<int, int, int> multiply = (x, y) => x * y;

            int res1 = Calculate(5, 3, add);
            int res2 = Calculate(5, 3, multiply);

            Console.WriteLine("Sum: " + res1);
            Console.WriteLine("Produt: " + res2);
        }

        static int Calculate(int a, int b, Func<int, int, int> operation)
        {
            return operation(a, b);
        }
    }
}
