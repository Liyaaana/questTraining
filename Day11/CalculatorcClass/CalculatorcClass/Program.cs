using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorClass
{
    class Calculator
    {
        private int a;
        private int b;
        public void Add() => Console.WriteLine(a + b);

        public void Sub() => Console.WriteLine(a - b);

        public void Mul() => Console.WriteLine(a * b);

        public void Divi() => Console.WriteLine(a / b);

        public void Run()
        {
            Console.Write("Enter number1 : ");
            // Converts a specified value to a 32-bit signed integer.
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number2 : ");
            b = Convert.ToInt32(Console.ReadLine());

            Add();
            Sub();
            Mul();
            Divi();
        }
       
    }
    internal class Program
    {
        static void Main()
        {
            var c = new Calculator();
            while (true)
            {
                c.Run();
            }    
        }
    }
}
