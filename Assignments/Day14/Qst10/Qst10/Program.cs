//10: Create an Action<int, int> delegate that takes two integers and prints their sum.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qst10
{
    internal class ActionDelegateTwo
    {
        public static void Add(int a, int b) => Console.WriteLine(a + b);
        static void Main(string[] args)
        {
            Action<int, int> sum = Add;
            sum(6, 7);
        }

    }
}

