using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
{
    class MyCustomException : Exception
    {
        public MyCustomException(string message) : base(message)// Pass the message to the base Exception
        {        
            // No need to define Message here, as it's already inherited from Exception
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter two numbers:");
                int i = int.Parse(Console.ReadLine());
                int j = int.Parse(Console.ReadLine());

                if (j == 0)
                {
                    // Throwing the custom exception
                    throw new MyCustomException("Second number should not be zero.");
                }
                Console.WriteLine(i / j);
            }
            catch (MyCustomException e)
            {
                Console.WriteLine($"Custom Exception: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"General Exception: {e.Message}");
            }
        }
    }
}
    