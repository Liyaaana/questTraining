using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qst4
{
    /* 4: Write an interface ICalculator that has methods 
       Add(int a, int b) and Subtract(int a, int b). 
       Implement this interface in a SimpleCalculator class.
    */
    interface ICalculator
    {
        int Add(int a, int b);
        int Subtract(int a, int b);
    }

    // SimpleCalculator class implementing ICalculator
    class SimpleCalculator : ICalculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of SimpleCalculator
            ICalculator calculator = new SimpleCalculator();

            // Example usage
            int resultAdd = calculator.Add(10, 5);
            int resultSubtract = calculator.Subtract(10, 5);

            Console.WriteLine($"Addition result: {resultAdd}");
            Console.WriteLine($"Subtraction result: {resultSubtract}");
        }
    }
}
