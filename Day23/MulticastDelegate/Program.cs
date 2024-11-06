using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDelegate
{
    public delegate void Display();
    internal class Program
    {
        public static void Method1()
        {
            Console.WriteLine("Method1.");
        }

        public static void Method2()
        {
            Console.WriteLine("Method2.");
        }
        public static void Main(string[] args)
        {
            Display display = Method1;
            display += Method2;

            display();
        }
    }
}

